using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///app分类
    ///</summary>
    [SugarTable("l_category_app")]
    public partial class L_category_appPO
    {
           public L_category_appPO(){

            this.OrderNum =0;

           }
           /// <summary>
           /// Desc:游戏分类
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long CategoryID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:父节点ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ParentId {get;set;}

    }
}
