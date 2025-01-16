using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sa_signin_level")]
    public partial class Sa_signin_levelPO
    {
           public Sa_signin_levelPO(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int LevelID {get;set;}

           /// <summary>
           /// Desc:图片相对路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? PicPath {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

           /// <summary>
           /// Desc:最小金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? MinMoney {get;set;}

           /// <summary>
           /// Desc:最大金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? MaxMoney {get;set;}

           /// <summary>
           /// Desc:下注金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? PetMoney {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Index {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Level {get;set;}

           /// <summary>
           /// Desc:连续天数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Days {get;set;}

    }
}
