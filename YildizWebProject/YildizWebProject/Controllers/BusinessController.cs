using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;
using EntitiyLayer.Concrete;

namespace YildizWebProject.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Business
        BusinessManager businessManager = new BusinessManager(new EfBusinessDal());
        public ActionResult Index()
        {
            var degerler = businessManager.GetAll();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniHizmet()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult YeniHizmet(Business business)
        {
            businessManager.Insert(business);
            return RedirectToAction("Index");
        }
        public ActionResult SilHizmet(int id)
        {
            var hizmet = businessManager.Get(id);
            hizmet.statu = false;
            businessManager.Update(hizmet);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GuncelleHizmet(int id)
        {
            var guncelle = businessManager.Get(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult GuncelleHizmet(Business business)
        {
            businessManager.Update(business);
            return RedirectToAction("Index");
        }
    }
}