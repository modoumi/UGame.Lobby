using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///app类别表
    ///</summary>
    [SugarTable("l_category")]
    public partial class L_categoryPO
    {
           public L_categoryPO(){

            this.OrderNum =0;
            this.LevelNum =0;
            this.Template =0;
            this.CategoryIcon ="";
            this.RecDate =DateTime.Now;
            this.TopLevelType =0;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long CategoryID {get;set;}

           /// <summary>
           /// Desc:运营商编码(null为默认)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:分类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:分类级别1开始
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LevelNum {get;set;}

           /// <summary>
           /// Desc:父节点ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? ParentId {get;set;}

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
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:顶级分类类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TopLevelType {get;set;}

    }
}
