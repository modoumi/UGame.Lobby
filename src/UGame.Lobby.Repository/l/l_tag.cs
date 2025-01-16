using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///app类别表
    ///</summary>
    [SugarTable("l_tag")]
    public partial class L_tagPO
    {
           public L_tagPO(){

            this.TagType =0;
            this.OrderNum =0;
            this.LevelNum =0;
            this.LevelOrderNum =0;
            this.TagIcon ="";
            this.SelectIcon ="";
            this.Template =0;
            this.TagUrl ="";
            this.UpdateDate =DateTime.Now;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:标签编号，
			/// 推荐标签=111，
			/// 全部标签=10000
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int TagCode {get;set;}

           /// <summary>
           /// Desc:标签名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:标签类型0:默认未启用，1:游戏，2:APP下载页，3:活动，4：首页，100:供应商
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TagType {get;set;}

           /// <summary>
           /// Desc:All标签时位置排序
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:标签等级1:一级页签，2:二级页签,3:一级和二级页都存在
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LevelNum {get;set;}

           /// <summary>
           /// Desc:等级排序
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LevelOrderNum {get;set;}

           /// <summary>
           /// Desc:标签图标
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TagIcon {get;set;}

           /// <summary>
           /// Desc:选中标签图标样式
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SelectIcon {get;set;}

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
           /// Desc:跳转地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? TagUrl {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime UpdateDate {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
