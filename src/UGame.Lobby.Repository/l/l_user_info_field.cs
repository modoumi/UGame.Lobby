using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///用户信息字段定义
    ///</summary>
    [SugarTable("l_user_info_field")]
    public partial class L_user_info_fieldPO
    {
           public L_user_info_fieldPO(){


           }
           /// <summary>
           /// Desc:用户字段主键（如：Username）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UIFieldID {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

    }
}
