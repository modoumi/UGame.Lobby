using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///活动事件基础数据表
    ///</summary>
    [SugarTable("l_activity_event_base")]
    public partial class L_activity_event_basePO
    {
           public L_activity_event_basePO(){


           }
           /// <summary>
           /// Desc:活动事件id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ActivityEventId {get;set;}

           /// <summary>
           /// Desc:活动事件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? EventName {get;set;}

    }
}
