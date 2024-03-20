using StoreX.BusinessLogic.Core;
using StoreX.BusinessLogic.Interface;
using StoreX.Domain.Entities.Respond;
using StoreX.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreX.BusinessLogic.MainBL
{
    public class LoginBL : UserApi, ILogin
    {
        public LoginCheckResponse Loginator(LoginData loginData)
        {
            return CheckLoginUser(loginData);
        }
    }
}
