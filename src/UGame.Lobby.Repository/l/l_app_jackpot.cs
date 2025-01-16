﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///app的jackpot
    ///</summary>
    [SugarTable("l_app_jackpot")]
    public partial class L_app_jackpotPO
    {
           public L_app_jackpotPO(){

            this.Jackpot =0;

           }
           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:源表jackpot字段名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SourceField {get;set;}

           /// <summary>
           /// Desc:源表名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SourceTable {get;set;}

           /// <summary>
           /// Desc:jackpot值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Jackpot {get;set;}

    }
}
