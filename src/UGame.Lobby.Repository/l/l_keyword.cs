﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///关键词
    ///</summary>
    [SugarTable("l_keyword")]
    public partial class L_keywordPO
    {
           public L_keywordPO(){

            this.OrderNum =0;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long KeywordID {get;set;}

           /// <summary>
           /// Desc:运营商编码(null意味着默认)
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
           /// Desc:关键字名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:分类编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long KCID {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
