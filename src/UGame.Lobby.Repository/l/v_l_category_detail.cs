using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///VIEW
    ///</summary>
    [SugarTable("v_l_category_detail")]
    public partial class V_l_category_detailPO
    {
           public V_l_category_detailPO(){

            this.CategoryOrderNum =0;
            this.Template =0;
            this.CategoryIcon ="";
            this.AppOrderNum =0;
            this.Flag =0;

           }
           /// <summary>
           /// Desc:父节点ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ParentId {get;set;}

           /// <summary>
           /// Desc:运营商编码(null为默认)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CategoryOrderNum {get;set;}

           /// <summary>
           /// Desc:显示模板
			/// 1、6*3
			/// 2、3*3
			/// 3、5*3
			/// 4、3*40
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Template {get;set;}

           /// <summary>
           /// Desc:游戏分类图标
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CategoryIcon {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int AppOrderNum {get;set;}

           /// <summary>
           /// Desc:游戏分类
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CategoryID {get;set;}

           /// <summary>
           /// Desc:分类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CategoryName {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AppID {get;set;}

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
