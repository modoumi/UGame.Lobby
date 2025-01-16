using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Diagnostics.NETCore.Client;
using System.Diagnostics;
using System.Runtime;
using AiUo.AspNet;

namespace UGame.Lobby.WebAPI.Controllers
{
    /// <summary>
    /// Test
    /// </summary>
    [AllowAnonymous]
    public class TestController : AiUoControllerBase
    {
        //[HttpGet]
        //public async Task<string> Test()
        //{
        //    if (!ConfigUtil.IsDebugEnvironment)
        //        return null;
        //    return HttpContextEx.GetSessionOrDefault<string>("test", null);
        //}

        private static Process _process = Process.GetCurrentProcess();
        private static TimeSpan _oldCPUTime = TimeSpan.Zero;
        private static DateTime _lastMonitorTime = DateTime.UtcNow;
        private static DateTime _lastRpsTime = DateTime.UtcNow;
        private static double _cpu = 0, _rps = 0;
        private static readonly double RefreshRate = TimeSpan.FromSeconds(1).TotalMilliseconds;
        public static long Requests = 0;

        [HttpGet]
        public ActionResult Diagnostics()
        {
            var now = DateTime.UtcNow;
            _process.Refresh();

            var cpuElapsedTime = now.Subtract(_lastMonitorTime).TotalMilliseconds;

            if (cpuElapsedTime > RefreshRate)
            {
                var newCPUTime = _process.TotalProcessorTime;
                var elapsedCPU = (newCPUTime - _oldCPUTime).TotalMilliseconds;
                _cpu = elapsedCPU * 100 / Environment.ProcessorCount / cpuElapsedTime;

                _lastMonitorTime = now;
                _oldCPUTime = newCPUTime;
            }

            var rpsElapsedTime = now.Subtract(_lastRpsTime).TotalMilliseconds;
            if (rpsElapsedTime > RefreshRate)
            {
                _rps = Requests * 1000 / rpsElapsedTime;
                Interlocked.Exchange(ref Requests, 0);
                _lastRpsTime = now;
            }

            var diagnostics = new
            {
                Gc = GCSettings.IsServerGC == true ? "Server" : "Workstation",

                PID = _process.Id,

                Allocated = GC.GetTotalMemory(false),

                WorkingSet = _process.WorkingSet64,

                PrivateBytes = _process.PrivateMemorySize64,

                Gen0 = GC.CollectionCount(0),

                Gen1 = GC.CollectionCount(1),

                Gen2 = GC.CollectionCount(2),

                CPU = _cpu,

                RPS = _rps
            };

            return new ObjectResult(diagnostics);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public List<string> Processes()
        {
            var data = DiagnosticsClient.GetPublishedProcesses()
                        .Select(Process.GetProcessById)
                        .Where(process => process != null)
                        .Select(o => { return $"id:{o.Id} name:{o.ProcessName} threads:{o.Threads.Count}"; });
            return data.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="dumpType"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<string> Dump(int processId, int dumpType = 4)
        {
            var client = new DiagnosticsClient(processId);
            var path = "./tmp";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var file = $"{path}/dump.{processId}-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
            var dt = (DumpType)dumpType;
            await client.WriteDumpAsync(dt, file, false, CancellationToken.None);
            return "ok";
        }
    }
}
