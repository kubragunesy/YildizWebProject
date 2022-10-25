using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;
using EntitiyLayer.Concrete;
using BusinessLayer.Validations;
using FluentValidation;
using PagedList;
using PagedList.Mvc;
using System.Web;
using System.IO;
using System;

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
        public ActionResult YeniHizmet(Business business, HttpPostedFileBase businessIcon)
        {

            var sonuc = businessValidation.Validate(business);
            if (sonuc.IsValid)
            {

                try
                {

                    if (businessIcon != null && businessIcon.ContentLength > 0)
                    {
                        string path = Path.Combine(Server.MapPath("~/Icon"), Path.GetFileName(businessIcon.FileName));
                        businessIcon.SaveAs(path);
                        business.businessIcon = businessIcon.FileName;
                        businessManager.Insert(business);
                    }
                    else
                    {
                        return View();
                    }

                }
                //catch (Exception exc)
                //{
                //    ViewBag.message = exc.Message.ToString();

                //}
                catch (Exception)
                {
                    ViewBag.message = "Görsel seçilmedi";

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
        public ActionResult GuncelleHizmet(Business business, HttpPostedFileBase businessIcon)
        {

            var sonuc = businessValidation.Validate(business);
            if (sonuc.IsValid)
            {

                try
                {

                    if (businessIcon != null && businessIcon.ContentLength > 0)
                    {
                        string path = Path.Combine(Server.MapPath("~/Icon"), Path.GetFileName(businessIcon.FileName));
                        businessIcon.SaveAs(path);
                        business.businessIcon = businessIcon.FileName;
                        businessManager.Insert(business);
                    }
                    else
                    {
                        return View();
                    }

                }
                //catch (Exception exc)
                //{
                //    ViewBag.message = exc.Message.ToString();

                //}
                catch (Exception)
                {
                    ViewBag.message = "Görsel seçilmedi";

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



    }
}