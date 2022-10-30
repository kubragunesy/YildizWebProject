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
            
            return View();
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
            //if (contact.customerName!=null && contact.customerLastName!=null && contact.customerMail!=null && contact.customerPhoneNumber!=null && contact.customerMessage!=null)
            //{
            //    WebMail.SmtpServer = "smpt.gmail.com";
            //    WebMail.EnableSsl= true;
            //    WebMail.UserName = "insaatisii@gmail.com";
            //    WebMail.Password = "insaat61";
            //    WebMail.SmtpPort = 587;
            //    WebMail.Send("insaatisii@gmail.com", contact.customerMail, contact.customerName, contact.customerLastName + "</br>" +  contact.customerMessage);
            //    ViewBag.Uyari = "Mesajınız başarıyla gönderilmiştir";
            //}
            //else
            //{
            //    ViewBag.Uyari = "Hata Oluştu. Tekrar Deneyiniz";
            //}


            //MailMessage mail = new MailMessage();
            //mail.IsBodyHtml = true;
            //mail.To.Add("insaatisii@gmail.com"); //mail gönderilen adres
            //mail.From = new MailAddress(contact.customerMail); //maili gönderen adres
            //mail.Subject = "İletişim Formu";
            //string adsoyad = "İsim Soyism : " + contact.customerName + contact.customerLastName+ "adsoyad" + "<br/>";
            //string eposta = "E-Posta Adresi : " + contact.customerMail+ "email" + "<br/>";
            //string ceptel = "Cep Telefonu : " + contact.customerPhoneNumber + "gsm" + "<br/>";
            //string mesaj = "Mesaj : " + contact.customerMessage +"mesaj" + "<br/>";
            //string Body = adsoyad + eposta + ceptel + mesaj;
            //mail.Body = Body;
            //SmtpClient smtp = new SmtpClient(); 
            //smtp.Host = "smtp.gmail.com"; //mail serverının host bilgisi
            //smtp.Port = 587; //mail serverının portu
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new System.Net.NetworkCredential("insaatisii@gmail.con", "insaat61"); //mail serverının kullanıcı bilgileri
            //smtp.Send(mail);

            //MailMessage mail=new MailMessage();
            //mail.To.Add("abdussametsolak@outlook.com"); // kıme
            //mail.From = new MailAddress("abdussametsolak@outlook.com"); //kımden
            //mail.Subject = "Bize Ulasın Sayfasından Mesajınız Var";
            //mail.Body = contact.customerMessage;
            //mail.IsBodyHtml = true;

            //SmtpClient smtp = new SmtpClient();
            //smtp.Credentials = new NetworkCredential("abdussametsolak@outlook.com","sifre");
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

            try
            {
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