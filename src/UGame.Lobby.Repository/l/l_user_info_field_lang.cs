using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户信息字段国家多语言定义
    ///</summary>
    [SugarTable("l_user_info_field_lang")]
    public partial class L_user_info_field_langPO
    {
           public L_user_info_field_langPO(){

            this.IsRequired =0;
            this.IsAllowModify =0;
            this.OrderNum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户字段主键（如：Username）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UIFieldID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:语言
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:菜单显示标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:输入提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Placeholder {get;set;}

           /// <summary>
           /// Desc:错误提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ErrorMessage {get;set;}

           /// <summary>
           /// Desc:是否必填
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsRequired {get;set;}

           /// <summary>
           /// Desc:是否允许修改
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsAllowModify {get;set;}

           /// <summary>
           /// Desc:排序，从小到大
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:数据类型,1-datetime
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? DBType {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
