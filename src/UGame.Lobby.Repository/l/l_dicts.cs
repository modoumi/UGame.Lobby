using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///字典表
    ///</summary>
    [SugarTable("l_dicts")]
    public partial class L_dictsPO
    {
           public L_dictsPO(){

            this.Type =0;

           }
           /// <summary>
           /// Desc:键Key
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DictID {get;set;}

           /// <summary>
           /// Desc:类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Category {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:类型0-系统1-用户定义
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:值Value
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Value {get;set;}

    }
}
