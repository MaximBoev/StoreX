using StoreX.Domain.Entities.Respond;
using StoreX.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreX.BusinessLogic.Interface
{
    public interface ILogin
    {
        LoginCheckResponse Loginator(LoginData loginData);
    }
}
