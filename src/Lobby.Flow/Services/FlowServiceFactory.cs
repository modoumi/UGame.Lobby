using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common.Caching;

namespace Lobby.Flow
{
    public static class FlowServiceFactory
    {
        public static IFlowService CreateFlowService(string userId, string appId, string operatorId)
        {
            var operatorInfo = DbCacheUtil.GetOperator(operatorId);
            return operatorInfo.FlowMode switch
            {
                1 => new FlowModeOneService(userId, appId, operatorId),
                3 => new FlowModeThreeService(userId, appId, operatorId),
                2 => new FlowModeTwoService(userId, appId, operatorId),
                _ => throw new Exception($"CreateFlowService参数错误，FlowMode:{operatorInfo.FlowMode}")
            } ;
        }
    }
}
