using ReactAspx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactAspx.Controllers
{
    public class DataController : Controller
    {
        public IList<FoodItem> menuItems;
        // GET: Data
        [HttpGet]
        public ActionResult GetMenuList()
        {
            menuItems = new List<FoodItem>();

            using (var db = new AppDbContext())
            {
                foreach (var f in db.FoodItems)
                {
                    menuItems.Add(f);
                }
            }

            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public string GetUserID()
        {
            int uid = -1;

            if (Session["UserId"] != null)
            {
                uid = Convert.ToInt32(Session["UserId"].ToString());
            }

            return uid.ToString();
        }

        [HttpPost]
        public ActionResult PlaceOrder()
        {
            return null;
        }
    }
}