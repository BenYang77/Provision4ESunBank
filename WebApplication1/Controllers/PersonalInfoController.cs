using Org.BouncyCastle.Asn1.Crmf;
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
        public void PubInfo() { ViewBag.Subject = "Personal Info"; }
        public ActionResult Index()
        {            
            ViewBag.Title = "Personal Info";
            var pList = new Biz.PersonalInfoBiz().getList();
            return View(pList);
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Personal Info";
            var pList = new PersonalInfoModel();
            return View(pList);
        }
        [HttpPost]
        public ActionResult Create(PersonalInfoModel personalInfo)
        {
            //write code to update student 
            ViewBag.Title = "Create";
            var pList = new Biz.PersonalInfoBiz().insertThisList(personalInfo);
            return RedirectToAction("Index");
        }

        [ActionName("Delete")]
        public ActionResult DeleteAction(int id)
        {
            var pList = new Biz.PersonalInfoBiz().getThisList(id).FirstOrDefault();
            return View(pList);
        }

        [HttpPost]
        public ActionResult Delete(PersonalInfoModel personalInfo)
        {
            //write code to update student 
            ViewBag.Title = "Delete";
            var pList = new Biz.PersonalInfoBiz().deleteThisList(personalInfo);
            return RedirectToAction("Index");
        }

        [ActionName("Edit")]
        public ActionResult EditAction(int id)
        {
            PubInfo();
            var pList = new Biz.PersonalInfoBiz().getThisList(id).FirstOrDefault();

            return View(pList);
        }

        [HttpPost]
        public ActionResult Edit(PersonalInfoModel personalInfo)
        {
            //write code to update student 
            ViewBag.Title = "Edit";
            var pList = new Biz.PersonalInfoBiz().updateThisList(personalInfo);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public ActionResult DetailsAction(int id)
        {
            PubInfo();
            ViewBag.Title = "Details";
            var pList = new Biz.PersonalInfoBiz().getThisList(id).FirstOrDefault();
            return View(pList);
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
