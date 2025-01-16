using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///VIEW
    ///</summary>
    [SugarTable("v_l_keyword_app")]
    public partial class V_l_keyword_appPO
    {
           public V_l_keyword_appPO(){

            this.Flag =0;

           }
           /// <summary>
           /// Desc:关键词编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long KeywordID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PrimaryKeyID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:应用标志 0-默认1-Hot2-New
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Flag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmallIcon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MiddleIcon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BigIcon {get;set;}

    }
}
