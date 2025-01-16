using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Lobby.Service.Services.Validates
{
    public interface IValidateField
    {
        Task<bool> Check(string fieldValue, string countryId);
    }
}
