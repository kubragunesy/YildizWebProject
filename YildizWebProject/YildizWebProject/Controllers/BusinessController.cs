using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;
using EntitiyLayer.Concrete;
using BusinessLayer.Validations;
using FluentValidation;
using PagedList;
using PagedList.Mvc;

namespace YildizWebProject.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Business
        BusinessManager businessManager = new BusinessManager(new EfBusinessDal());
        BusinessValidation businessValidation = new BusinessValidation();
        public ActionResult Index(int p = 1)
        {
            //var degerler = businessManager.GetAll();
            var degerler = businessManager.GetAll().ToPagedList(p, 5);
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
            var sonuc = businessValidation.Validate(business);
            if (sonuc.IsValid)
            {
                businessManager.Insert(business);
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