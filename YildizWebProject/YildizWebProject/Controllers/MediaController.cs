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
    }
}