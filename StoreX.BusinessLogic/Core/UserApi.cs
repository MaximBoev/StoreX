using StoreX.Domain.Entities.Respond;
using StoreX.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreX.BusinessLogic.Core
{
    public class UserApi
    {
        public LoginCheckResponse CheckLoginUser(LoginData LD)
        {
            LoginCheckResponse LCR = new LoginCheckResponse();
            if (LD.Username == "himera" && LD.Password == "123")
            {
                LCR.Success = true;
                return LCR;
            }
            LCR.Success = false;
            return LCR;
        }
    }
}
