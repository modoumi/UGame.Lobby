using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///关键词app
    ///</summary>
    [SugarTable("l_keyword_app")]
    public partial class L_keyword_appPO
    {
           public L_keyword_appPO(){


           }
           /// <summary>
           /// Desc:关键词编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long KeywordID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

    }
}
