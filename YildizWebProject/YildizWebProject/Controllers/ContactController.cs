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
    public class ContactController : Controller
    {
        // GET: Contact
       ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            var degerler = contactManager.GetAll();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniİletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeniİletisim(Contact contact)
        {
            contactManager.Insert(contact);
            return RedirectToAction("Index");
        }
        public ActionResult SilIletisim(int id)
        {
            var iletisim= contactManager.Get(id);
            iletisim.statu = false;
            contactManager.Update(iletisim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GuncelleIletisim(int id)
        {
            var guncelle= contactManager.Get(id);
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult GuncelleIletisim(Contact contact)
        {
            contactManager.Update(contact);
            return RedirectToAction("Index");
        }


    }
}