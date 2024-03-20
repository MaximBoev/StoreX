using StoreX.BusinessLogic.Interface;
using StoreX.Domain.Entities.Respond;
using StoreX.Domain.Entities.User;
using StoreX.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace StoreX.Controllers
{
    public class LoginController : Controller
    {
        internal ILogin ILogin;

        public LoginController()
        {
            var tmp = new BusinessLogic.BusinessLogic();
            ILogin = tmp.GetLogin();
        }

        [HttpPost]
        public ActionResult LoginAction(MLoginData MLogin)
        {
            LoginData LoginD = new LoginData()
            {
                Username = MLogin.Username,
                Password = MLogin.Password,
            };
            LoginCheckResponse LCR = ILogin.Loginator(LoginD);
            if(LCR.Success == true)
            {
                return View("~/Views/Home/Store.cshtml");
            }
            return View("~/Views/Home/Registration.cshtml");

        }
    }
}