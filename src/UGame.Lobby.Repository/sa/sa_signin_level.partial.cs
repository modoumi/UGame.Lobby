using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.Lobby.Repository.ing
{
    [SugarConfigId("ing")]
    public partial class Sa_signin_levelPO
    {
        #region AiUo
        public static implicit operator Sa_signin_levelEO(Sa_signin_levelPO value)
        {
            if (value==null) return null;
            return new Sa_signin_levelEO
            {
		        LevelID = value.LevelID,
		        PicPath = value.PicPath,
		        Name = value.Name,
		        MinMoney = value.MinMoney,
		        MaxMoney = value.MaxMoney,
		        PetMoney = value.PetMoney,
		        Index = value.Index,
		        OperatorID = value.OperatorID,
		        CurrencyId = value.CurrencyId,
		        CountryID = value.CountryID,
		        Level = value.Level,
		        Days = value.Days,
            };
        }
        public static implicit operator Sa_signin_levelPO(Sa_signin_levelEO value)
        {
            if (value==null) return null;
            return new Sa_signin_levelPO
            {
		        LevelID = value.LevelID,
		        PicPath = value.PicPath,
		        Name = value.Name,
		        MinMoney = value.MinMoney,
		        MaxMoney = value.MaxMoney,
		        PetMoney = value.PetMoney,
		        Index = value.Index,
		        OperatorID = value.OperatorID,
		        CurrencyId = value.CurrencyId,
		        CountryID = value.CountryID,
		        Level = value.Level,
		        Days = value.Days,
            };
        }
        #endregion
    }
}