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

        //[HttpPost]
        //public ActionResult PostAction()
        //{
        //    return View("Index");
        //}

        [HttpDelete]
        [ActionName("Delete")]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        //[HttpHead]
        //public ActionResult HeadAction()
        //{
        //    return View("Index");
        //}

        //[HttpOptions]
        //public ActionResult OptionsAction()
        //{
        //    return View("Index");
        //}

        //[HttpPatch]
        //[System.Web.Mvc.ActionName("")]
        //public ActionResult PatchAction()
        //{
        //    return View("Index");
        //}
    }
}
