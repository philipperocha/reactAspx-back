using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactAspx.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        [HttpGet]
        public ActionResult GetMenuList()
        {
            return null;
        }

        [HttpGet]
        public string GetUserID()
        {
            return "1";
        }

        [HttpPost]
        public ActionResult PlaceOrder()
        {
            return null;
        }
    }
}