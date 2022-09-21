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
    public class MediaController : Controller
    {
        // GET: Media
        MediaManager mediaManager = new MediaManager(new EfMediaDal());
        MediaValidation mediaValidation = new MediaValidation();
        public ActionResult Index(int s = 1)
        {
            //var degerler = mediaManager.GetAll();
            var degerler = mediaManager.GetAll().ToPagedList(s, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMedia(Media media)
        {
            var sonuc = mediaValidation.Validate(media);
            if (sonuc.IsValid)
            {
                mediaManager.Insert(media);
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
        public ActionResult SilMedia(int id)
        {
            var media = mediaManager.Get(id);
            media.statu = false;
            mediaManager.Update(media);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GuncelleMedia(int id)
        {
            var guncelle=mediaManager.Get(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult GuncelleMedia(Media media)
        {
            mediaManager.Update(media);
            return RedirectToAction("Index");
        }

    }
}