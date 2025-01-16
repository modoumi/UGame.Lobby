using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sm_message_extend")]
    public partial class Sm_message_extendPO
    {
           public Sm_message_extendPO(){

            this.RecDate =DateTime.Now;
            this.UpdateTime =DateTime.Now;

           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ExtendID {get;set;}

           /// <summary>
           /// Desc:邮件编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MessageID {get;set;}

           /// <summary>
           /// Desc:语种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

           /// <summary>
           /// Desc:创建时间
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
           /// Desc:广告图
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ImgURL {get;set;}

           /// <summary>
           /// Desc:跳转链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? HyperLink {get;set;}

           /// <summary>
           /// Desc:过期时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ExpireTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Remark {get;set;}

    }
}
