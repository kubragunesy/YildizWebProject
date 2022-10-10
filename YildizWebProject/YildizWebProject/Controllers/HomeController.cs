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

        public ActionResult Index()
        {
            return View();
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
            //MailMessage mail=new MailMessage();
            //mail.To.Add("abdussametsolak@outlook.com"); // kıme
            //mail.From = new MailAddress("abdussametsolak@outlook.com"); //kımden
            //mail.Subject = "Bize Ulasın Sayfasından Mesajınız Var";
            //mail.Body = contact.customerMessage;
            //mail.IsBodyHtml = true;

            //SmtpClient smtp = new SmtpClient();
            //smtp.Credentials = new NetworkCredential("abdussametsolak@outlook.com","Abdussamet4*81f396bf");
            ////gonderen kısının bilgileri
            //smtp.Port = 587;
            //smtp.Host = "smtp.live.com";
            ////outlook hesabından gonderılıırse
            //smtp.EnableSsl= true;

            //try
            //{
            //    contactManager.Insert(contact);
            //    smtp.Send(mail);
            //    TempData["Message"] = "mail gonderıldi";
            //}
            //catch (Exception ex)
            //{
            //    TempData["Message"]="mail gonderılemedi "+ex.Message;

            //}
            
            contactManager.Insert(contact);
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