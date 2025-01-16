using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///事件
    ///</summary>
    [SugarTable("sat_event")]
    public partial class Sat_eventPO
    {
           public Sat_eventPO(){

            this.EventType =0;

           }
           /// <summary>
           /// Desc:事件编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int EventID {get;set;}

           /// <summary>
           /// Desc:事件类型0-未知1-MQ2-定时
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int EventType {get;set;}

           /// <summary>
           /// Desc:事件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

    }
}
