using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace YildizWebProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        ProjectValidation projectValidation = new ProjectValidation();
        public ActionResult Index(int m = 1)
        {
            //var degerler = projectManager.GetAll();
            var degerler = projectManager.GetAll().ToPagedList(m, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniProje()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniProje(Project project)
        {
            var sonuc = projectValidation.Validate(project);
            if (sonuc.IsValid)
            {
                projectManager.Insert(project);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in sonuc.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult SilProje(int id)
        {
            var project = projectManager.Get(id);
            project.statu = false;
            projectManager.Update(project);
            return View(project);
        }
        [HttpGet]
        public ActionResult GuncelleProje (int id)
        {
            var guncelle=projectManager.Get(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult GuncelleProje(Project project)
        {
            projectManager.Update(project);
            return RedirectToAction("Index");
        }
    }
}