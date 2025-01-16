using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    ///<summary>
    ///跑马灯具体用户
    ///</summary>
    [SugarTable("sc_marquee_user")]
    public partial class Sc_marquee_userPO
    {
           public Sc_marquee_userPO(){


           }
           /// <summary>
           /// Desc:跑马灯编码GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MarqueeID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

    }
}
