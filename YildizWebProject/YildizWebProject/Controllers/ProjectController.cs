using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YildizWebProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public ActionResult Index()
        {
            var degerler = projectManager.GetAll();
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
            projectManager.Insert(project);
            return RedirectToAction("Index");
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