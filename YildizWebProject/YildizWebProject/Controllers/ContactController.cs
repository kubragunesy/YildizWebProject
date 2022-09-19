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
    }
}