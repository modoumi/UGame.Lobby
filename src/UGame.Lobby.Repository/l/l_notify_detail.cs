using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///通知明细
    ///</summary>
    [SugarTable("l_notify_detail")]
    public partial class L_notify_detailPO
    {
           public L_notify_detailPO(){


           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

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
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt1 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt2 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt3 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt4 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt5 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img1 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img2 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img3 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img4 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img5 {get;set;}

    }
}
