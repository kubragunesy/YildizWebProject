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
    public class MediaController : Controller
    {
        // GET: Media
        MediaManager mediaManager = new MediaManager(new EfMediaDal());
        public ActionResult Index()
        {
            var degerler = mediaManager.GetAll();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMedia()
        {
            return View();
        }
        public ActionResult YeniMedia(Media media)
        {
            mediaManager.Insert(media);
            return RedirectToAction("Index");
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