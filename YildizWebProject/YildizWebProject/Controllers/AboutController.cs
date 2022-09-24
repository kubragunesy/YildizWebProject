using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System.Web.Mvc;

namespace YildizWebProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var degerler = aboutManager.GetAll();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniAbout(About about)
        {
            aboutManager.Insert(about);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GuncelleAbout(int id)
        {
            var guncelle = aboutManager.Get(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult GuncelleAbout(About about)
        {
            aboutManager.Update(about);
            return RedirectToAction("Index");

        }
        public ActionResult SilAbout(int id)
        {
            var about = aboutManager.Get(id);
            aboutManager.Remove(about);
            return RedirectToAction("Index");
        }

    }
}