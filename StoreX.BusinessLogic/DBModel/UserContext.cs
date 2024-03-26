using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreX.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=StoreX") 
        { 
        }
    }
}
