using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///通知
    ///</summary>
    [SugarTable("l_notify")]
    public partial class L_notifyPO
    {
           public L_notifyPO(){

            this.ActionAt =0;
            this.ShowAt =0;
            this.Position =0;
            this.ShowInterval =0;
            this.ShowTimes =0;
            this.CloseInterval =0;
            this.OrderNum =0;
            this.LinkKind =0;
            this.BeginDate =Convert.ToDateTime("2000-01-01 00:00:00");
            this.EndDate =Convert.ToDateTime("9999-12-31 00:00:00");
            this.UserScope =0;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:供应商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ProviderId {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:何时展示1-登录前2-注册后第一次登录3登录后
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActionAt {get;set;}

           /// <summary>
           /// Desc:显示页面 FLAG值0-全部1-首页2-4-8
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowAt {get;set;}

           /// <summary>
           /// Desc:显示位置1-顶部2-中部3-下部
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Position {get;set;}

           /// <summary>
           /// Desc:展示间隔（分钟）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowInterval {get;set;}

           /// <summary>
           /// Desc:展示次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowTimes {get;set;}

           /// <summary>
           /// Desc:自动关闭间隔（秒）0-手动关闭
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CloseInterval {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:链接类型1-email 2-url
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LinkKind {get;set;}

           /// <summary>
           /// Desc:链接地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LinkUrl {get;set;}

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
           /// Desc:用户范围0-全部用户1-指定具体用户
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int UserScope {get;set;}

           /// <summary>
           /// Desc:范围值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ScopeValue {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
