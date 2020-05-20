using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

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

        [ActionName("Delete")]
        public ActionResult DeleteAction(int id)
        {
            return RedirectToAction("Index");
        }

        [ActionName("Edit")]
        public ActionResult EditAction(int id)
        {
            var pList = new Biz.PersonalInfoBiz().getThisList(id).FirstOrDefault();

            return View(pList);
        }

        [HttpPost]
        public ActionResult Edit(PersonalInfoModel personalInfo)
        {
            //write code to update student 
            var pList = new Biz.PersonalInfoBiz().updateThisList(personalInfo);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public ActionResult DetailsAction(int id)
        {
            return RedirectToAction("Index");
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
