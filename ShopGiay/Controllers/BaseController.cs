using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopGiay.Constant;
using ShopGiay.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopGiay.Controllers
{
    [AuthenticationFilter]
    public class BaseController : Controller
    {
        public BaseController() { }

        protected string GetUserName()
        {
            return HttpContext.Session.GetString(SessionKey.User.UserName);
        }

        protected string GetFullName()
        {
            return HttpContext.Session.GetString(SessionKey.User.FullName);
        }

        protected string GetEmailMem()
        {
            return HttpContext.Session.GetString(SessionKey.Guest.Guest_UserName);
        }
    }
}
