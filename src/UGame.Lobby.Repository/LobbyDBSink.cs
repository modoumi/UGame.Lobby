using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Configuration;
using AiUo.Data.MySql;
using UGame.Lobby.Repository.ing;

namespace UGame.Lobby.Repository
{
    public static class LobbyDBSink
    {
        private static MySqlDatabase _mainDb;
        public static MySqlDatabase MainDb
        {
            get
            {
                if (_mainDb == null)
                    _mainDb = new MySqlDatabase();
                return _mainDb;
            }
        }

        private static MySqlDatabase _gameDb;
        public static MySqlDatabase GameDb
        {
            get
            {
                if (_gameDb == null)
                {
                    var section = ConfigUtil.GetSection<DataSection>();
                    if (section == null || section.ConnectionStrings == null
                        || !section.ConnectionStrings.TryGetValue("game", out var _))
                        throw new Exception("配置文件中数据库连接名game不存在！");
                    _gameDb = new MySqlDatabase("game");
                }
                return _gameDb;
            }
        }

        public static L_user_activityMO BuildUserMo(string userId)
        {
            return new L_user_activityMO();
        }

    }
}
