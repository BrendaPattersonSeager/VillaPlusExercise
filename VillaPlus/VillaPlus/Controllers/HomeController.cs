using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VillaPlus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult CalculateDiscount(int itemPrice, int total, int discountCounter)
        {

                int discountTotal = 0;
                bool discountApplied = false;

                total = total + itemPrice;
                
    
                    if (discountCounter == 3)
                    {
                        discountTotal = total - itemPrice;
                        total = discountTotal;
                        discountApplied = true;
                        discountCounter = 0;
                    }


                return Json(new { total = total, discountApplied = discountApplied, discountCounter = discountCounter }, JsonRequestBehavior.AllowGet); 

            }
    }
}