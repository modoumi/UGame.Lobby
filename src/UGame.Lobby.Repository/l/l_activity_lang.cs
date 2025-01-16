using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///活动列表
    ///</summary>
    [SugarTable("l_activity_lang")]
    public partial class L_activity_langPO
    {
           public L_activity_langPO(){

            this.Kind =0;
            this.Mode =0;
            this.IndexNologinLinkUrl ="";
            this.IndexloginLinkUrl ="";
            this.OrderNum =0;
            this.BeginDate =Convert.ToDateTime("2000-01-01 00:00:00");
            this.EndDate =Convert.ToDateTime("9999-12-31 00:00:00");
            this.Status =0;

           }
           /// <summary>
           /// Desc:活动编码GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ActivityID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:活动类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Kind {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

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

           /// <summary>
           /// Desc:类型:0-位置1-图片2-html3-文字
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Mode {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

           /// <summary>
           /// Desc:链接地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LinkUrl {get;set;}

           /// <summary>
           /// Desc:首页未登录链接
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string IndexNologinLinkUrl {get;set;}

           /// <summary>
           /// Desc:首页登录后链接
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string IndexloginLinkUrl {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:起始日期（默认2016-01-01）
           /// Default:2000-01-01 00:00:00
           /// Nullable:False
           /// </summary>           
           public DateTime BeginDate {get;set;}

           /// <summary>
           /// Desc:截止日期（默认2099-01-01）
           /// Default:9999-12-31 00:00:00
           /// Nullable:False
           /// </summary>           
           public DateTime EndDate {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

    }
}
