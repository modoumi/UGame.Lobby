using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;

namespace UGame.Lobby.Service.Services.Validates.PersonalInfo
{
    public class NickNameValidate : IValidateField
    {
        public async Task<bool> Check(string fieldValue, string countryId)
        {
            //switch (countryId)
            //{
            //    case "BRA":
            //        if (string.IsNullOrWhiteSpace(fieldValue))
            //            throw new CustomException("NickName cannot be empty.");
            //        if(fieldValue.Length > 15)
            //            throw new CustomException("Enter a maximum of 15 characters for the NickName.");
            //        return false;
            //}
            return true;
        }
    }

    public class FirstNameValidate : IValidateField
    {
        public async Task<bool> Check(string fieldValue, string countryId)
        {
            switch (countryId)
            {
                case "BRA":
                    if (string.IsNullOrWhiteSpace(fieldValue))
                        throw new CustomException("FirstName cannot be empty.");
                    return false;
                case "MEX":
                    if (string.IsNullOrWhiteSpace(fieldValue))
                        throw new CustomException("FirstName cannot be empty.");
                    return false;
            }
            return true;
        }
    }

    public class LastNameValidate : IValidateField
    {
        public async Task<bool> Check(string fieldValue, string countryId)
        {
            switch (countryId)
            {
                case "BRA":
                    if (string.IsNullOrWhiteSpace(fieldValue))
                        throw new CustomException("LastName cannot be empty.");
                    return false;
                case "MEX":
                    if (string.IsNullOrWhiteSpace(fieldValue))
                        throw new CustomException("LastName cannot be empty.");
                    return false;
            }
            return true;
        }
    }

    public class BirthDayValidate : IValidateField
    {
        public async Task<bool> Check(string fieldValue, string countryId)
        {
            switch (countryId)
            {
                case "BRA":
                    if (string.IsNullOrWhiteSpace(fieldValue))
                        throw new CustomException("BirthDay cannot be empty.");
                    return false;
                case "MEX":
                    if (string.IsNullOrWhiteSpace(fieldValue))
                        throw new CustomException("BirthDay cannot be empty.");
                    return false;
            }
            return true;
        }
    }

    public class EmailValidate : IValidateField
    {
        public async Task<bool> Check(string fieldValue, string countryId)
        {
            if(!StringUtil.IsEmail(fieldValue))
                throw new CustomException("Illegal BirthDay format.");
            return true;
        }
    }
}
