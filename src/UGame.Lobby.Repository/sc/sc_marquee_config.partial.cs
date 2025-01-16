using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sc_marquee_configPO
    {
        #region AiUo
        public static implicit operator Sc_marquee_configEO(Sc_marquee_configPO value)
        {
            if (value==null) return null;
            return new Sc_marquee_configEO
            {
		        OperatorID = value.OperatorID,
		        WinMinAmount = value.WinMinAmount,
		        TextMaxNumber = value.TextMaxNumber,
		        PicMaxNumber = value.PicMaxNumber,
		        FakeWinMultiple = value.FakeWinMultiple,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sc_marquee_configPO(Sc_marquee_configEO value)
        {
            if (value==null) return null;
            return new Sc_marquee_configPO
            {
		        OperatorID = value.OperatorID,
		        WinMinAmount = value.WinMinAmount,
		        TextMaxNumber = value.TextMaxNumber,
		        PicMaxNumber = value.PicMaxNumber,
		        FakeWinMultiple = value.FakeWinMultiple,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}