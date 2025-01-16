using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户所在应用的数据
    ///</summary>
    [SugarTable("sc_user_app")]
    public partial class Sc_user_appPO
    {
           public Sc_user_appPO(){

            this.GuideNum =0;
            this.UserAppStatus =0;

           }
           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:用户引导显示内容
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int GuideNum {get;set;}

           /// <summary>
           /// Desc:用户状态(0-未知1-正常2-异常）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserAppStatus {get;set;}

           /// <summary>
           /// Desc:最后一次访问时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastLoginDate {get;set;}

    }
}
