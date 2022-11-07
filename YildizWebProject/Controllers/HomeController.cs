using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace YildizWebProject.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        BusinessManager businessManager = new BusinessManager(new EfBusinessDal());
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        CompanyInfoManager companyInfoManager = new CompanyInfoManager(new EfCompanyInfoDal());

        [HttpGet]
        public ActionResult Index()
        {
            var liste = businessManager.GetAll();   
            return View(liste);
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {

            try
            {
                contactManager.Insert(contact);
                TempData["Mesaj"] = "✓ Form başarılı bir şekilde ulaştı.";
            }
            catch (Exception ex)
            {
                TempData["Mesaj"] = ex.Message.ToString();

            }
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            var list = aboutManager.GetAll();
            return View(list);
        }
       
        [HttpGet]
        public ActionResult Contact()
        {
            var list = companyInfoManager.GetAll();       
            return View(list);
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {

            try
            {
                //var smtpClient = new SmtpClient("smtp.gmail.com")
                //{
                //    Port = 587,
                //    Credentials = new NetworkCredential("insaatisii@gmail.com", "guvenlik45"),
                //    EnableSsl = true,
                //};

                //smtpClient.Send(contact.customerMail, "insaatisii@gmail.com", "web sitenizden bir mail var", contact.customerMessage);
                contactManager.Insert(contact);
                TempData["Mesaj"] = "✓ Form başarılı bir şekilde ulaştı.";
            }
            catch (Exception)
            {
                TempData["Mesaj"] = "Hata oluştu, tekrar deneyiniz.";

            }

            return RedirectToAction("Contact");

          }
        public ActionResult Project()
        {
            var list = projectManager.GetAll();
            return View(list);
        }
        public ActionResult Business()
        {
            var list = businessManager.GetAll();
            return View(list);
        }
    }
}