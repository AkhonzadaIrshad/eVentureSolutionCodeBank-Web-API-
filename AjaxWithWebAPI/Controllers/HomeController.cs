using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxWithWebAPI.Controllers
{
    public class HomeController : Controller
    {

        static List<string> Emails=new  List<string>();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Submit Form";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email)
        {
            if (Emails.Where(x=>x.Equals(email)).FirstOrDefault()==null)
            {
                Emails.Add(email);
                ViewBag.Message = "Success";
                return View();
            }
            ViewBag.Message = "Already Exists";



            return View();
        }


        [HttpGet]
        public ActionResult CheckEmail(string email)
        {
            if (Emails.Where(x => x.Equals(email)).FirstOrDefault() != null)
            {
                return Content("true");
               // return Json(true);
            }
            return Content("false");

        }


    }
}