using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using DataAccessLayer.Concrete;

namespace YildizWebProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
       ContactManager contactManager = new ContactManager(new EfContactDal());
        Context context = new Context();
        public ActionResult Index(string p)
        {
            var degerler = from d in context.Contacts select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.customerName.Contains(p));
            }
            return View(degerler.ToList());
            //var degerler = contactManager.GetAll();
            //return View(degerler);
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