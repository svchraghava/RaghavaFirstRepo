using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class Demo1Controller : Controller, IActionFilter
    {
        //
        // GET: /Demo1/

        public ActionResult Index()     // connected by the browser and expects HTML
        {
            
            Customer obj = new Customer
            {
                CustomerId="1001",
                CustomerName="Raghava"
                
            };
            return View("Index",obj);
        }
        public ViewResult Work1()
        {
            return View();
        }
        public JsonResult Work2()        // Connected via the Jquery and expects Json
        {
            Customer obj = new Customer
            {
                CustomerId = "1001",
                CustomerName = "Raghava"
            };
            return Json("Work2", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Work3()
        {

            return View();
        }


        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Post processing Logic
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            //PRE Processing Logic
        }
    }

    public class Customer
    {

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
		public string CustomerAddress { get; set; }
    }
}
