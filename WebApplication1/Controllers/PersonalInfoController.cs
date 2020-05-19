using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonalInfoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Personal Info";
            var pList = new Biz.PersonalInfoBiz().getList();
            return View(pList);
        }
    }
}
