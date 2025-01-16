using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sm_message")]
    public partial class Sm_messagePO
    {
           public Sm_messagePO(){

            this.MessageID ="0";
            this.Type =0;
            this.State =0;
            this.RecDate =DateTime.Now;
            this.UpdateTime =DateTime.Now;

           }
           /// <summary>
           /// Desc:编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MessageID {get;set;}

           /// <summary>
           /// Desc:发件人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SenderID {get;set;}

           /// <summary>
           /// Desc:邮件类型0系统消息1最新动态2奖励邮件3私信
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:是否删除0未删除1已删除
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int State {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime UpdateTime {get;set;}

           /// <summary>
           /// Desc:奖励编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RewardID {get;set;}

    }
}
