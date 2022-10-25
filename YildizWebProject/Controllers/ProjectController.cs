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
using System.IO;

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
        public ActionResult YeniProje(Project project, HttpPostedFileBase projectMediaUrl)
        {
            //File file;
            var sonuc = projectValidation.Validate(project);
            if (sonuc.IsValid)
            {

                try
                {

                    if (projectMediaUrl != null && projectMediaUrl.ContentLength > 0)
                    {
                        string path = Path.Combine(Server.MapPath("~/Image"), Path.GetFileName(projectMediaUrl.FileName));
                        projectMediaUrl.SaveAs(path);
                        project.projectMediaUrl = projectMediaUrl.FileName;
                        projectManager.Insert(project);
                    }
                    else {
                        return View();
                    }

                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                }
               
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
            return RedirectToAction("Index");
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