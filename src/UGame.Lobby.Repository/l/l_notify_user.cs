﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///通知具体用户
    ///</summary>
    [SugarTable("l_notify_user")]
    public partial class L_notify_userPO
    {
           public L_notify_userPO(){


           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

    }
}
