using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///跑马灯语言
    ///</summary>
    [SugarTable("sc_marquee_lang")]
    public partial class Sc_marquee_langPO
    {
           public Sc_marquee_langPO(){


           }
           /// <summary>
           /// Desc:跑马灯编码GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MarqueeID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:消息内容
			///              恭喜{nickname}在{appName}中赢得{win}
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MessageContent {get;set;}

    }
}
