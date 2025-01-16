using EasyNetQ;
using StackExchange.Redis;
using AiUo.BIZ.RabbitMQ;
using AiUo.Configuration;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using Xxyy.MQ.Admin;

namespace UGame.Lobby.Service.MQConsumer;


public class ClearRedisMQSub : MQBizSubConsumer<CachingChangeMsg>
{

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    public ClearRedisMQSub()
    {
        AddHandler(ClearCaching);
    }
    private async Task ClearCaching(CachingChangeMsg message, CancellationToken cancellationToken)
    {
        if (message == null) return;

        if (!string.IsNullOrWhiteSpace(message.PrimaryKeyValue))
        {

            RedisSection section = ConfigUtil.GetSection<RedisSection>();

            var connectionString = section.ConnectionStrings[section.DefaultConnectionStringName].ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                LogUtil.GetContextLogger().AddMessage($"ClearRedisMQSub.ClearCaching;redis连接串为空");
                return;
            }


            if (ConfigUtil.Environment.IsDebug)
            {
                using (var _connMultiplexer = ConnectionMultiplexer.Connect(connectionString))
                {
                    var db = _connMultiplexer.GetDatabase();
                    foreach (var item in _connMultiplexer.GetEndPoints())
                    {
                        var server = _connMultiplexer.GetServer(item);
                        foreach (var msgKey in message.PrimaryKeyValue.Split(";"))
                        {
                            foreach (var key in server.Keys(0, $"{msgKey}*"))
                            {
                                await db.KeyDeleteAsync(key);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var primaryKeyItem in message.PrimaryKeyValue.Split(";"))
                {
                    if (string.IsNullOrWhiteSpace(primaryKeyItem))
                        continue;

                    string pattern = $"{primaryKeyItem}*";
                    int count = 1000;
                    int cursor = 0;
                    RedisKey[] redisKeys = new RedisKey[0];

                    try
                    {
                        using (var _connMultiplexer = ConnectionMultiplexer.Connect(connectionString))
                        {
                            var db = _connMultiplexer.GetDatabase();

                            //Stopwatch sw = new Stopwatch();
                            //sw.Start();

                            do
                            {
                                RedisResult results = await db.ExecuteAsync("SCAN", cursor, "MATCH", pattern, "COUNT", count);

                                var resultDic = results.ToDictionary();

                                foreach (var dicItem in resultDic)
                                {
                                    cursor = Convert.ToInt32(dicItem.Key);

                                    redisKeys = (RedisKey[])dicItem.Value;
                                    foreach (var key in redisKeys)
                                    {
                                        Console.WriteLine(key);
                                        await db.KeyDeleteAsync(key);
                                    }
                                    break;
                                }

                                //Console.WriteLine($"cursor:{cursor}");
                                //Console.WriteLine($"redisKeys:{JsonConvert.SerializeObject(redisKeys)}");
                                //Console.WriteLine("=============================================");
                            } while (cursor != 0);

                            //sw.Stop();
                            //Console.WriteLine($"耗时：" + sw.ElapsedMilliseconds);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogUtil.GetContextLogger().AddException(ex).AddMessage($"ClearRedisMQSub.ClearCaching;清理redis缓存异常");
                    }
                }
            }
        }
    }

    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    protected override Task OnMessage(CachingChangeMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
