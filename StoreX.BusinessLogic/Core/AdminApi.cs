using StoreX.Domain.Entities.Product;
using StoreX.Domain.Entities.Respond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreX.BusinessLogic.Core
{
    public class AdminApi
    {
        public ProdAddActionResp AddProductToDb(AProductData prod)
        {
            return new ProdAddActionResp { ActionStatus = false };
        }
    }
}
