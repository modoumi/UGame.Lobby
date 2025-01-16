using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///关键字分类
    ///</summary>
    [SugarTable("l_keyword_category")]
    public partial class L_keyword_categoryPO
    {
           public L_keyword_categoryPO(){

            this.OrderNum =0;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long KCID {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? KCName {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorId {get;set;}

           /// <summary>
           /// Desc:语言编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LangID {get;set;}

    }
}
