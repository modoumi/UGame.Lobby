using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///输出查询
    ///</summary>
    [SugarTable("l_query_input")]
    public partial class L_query_inputPO
    {
           public L_query_inputPO(){

            this.KeyType =1;

           }
           /// <summary>
           /// Desc:编码GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string QueryID {get;set;}

           /// <summary>
           /// Desc:语言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:类型1-游戏名2-分类3-keyword
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int KeyType {get;set;}

           /// <summary>
           /// Desc:查询关键字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? QueryKey {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AppID {get;set;}

    }
}
