using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sm_message_detail")]
    public partial class Sm_message_detailPO
    {
           public Sm_message_detailPO(){

            this.Flag =0;
            this.RecDate =DateTime.Now;
            this.UpdateTime =DateTime.Now;
            this.State =0;

           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DetailID {get;set;}

           /// <summary>
           /// Desc:邮件编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MessageID {get;set;}

           /// <summary>
           /// Desc:收件人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:0初始状态1已读未领奖励2已读已领取奖励3已读领取奖励失败
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Flag {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? RecDate {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdateTime {get;set;}

           /// <summary>
           /// Desc:是否删除0未删除1已删除
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int State {get;set;}

    }
}
