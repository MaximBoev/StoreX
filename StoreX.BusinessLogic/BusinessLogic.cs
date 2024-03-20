using StoreX.BusinessLogic.Interface;
using StoreX.BusinessLogic.MainBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreX.BusinessLogic
{
    public class BusinessLogic
    {
        public ILogin GetLogin()
        {
            return new LoginBL();
        }
    }
}
