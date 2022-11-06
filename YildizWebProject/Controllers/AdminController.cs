using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace YildizWebProject.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult LoginPanel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPanel(Admin admin)
        {
            Context context = new Context();
            var sonuc = context.Admins.FirstOrDefault(x => x.adminUserName == admin.adminUserName && x.password == admin.password);
            if (sonuc != null)
            {
                //Session nesneleri yardımıyla kullanıcılara ait oturum bilgileri sayfalar arasında taşınabilmektedir
                //FormsAuthentication giriş-çıkış işlemlerinde kullanılır.
                //Cookie kullanıcın websitesine girdiği anda kayıt altına alınan çerez türüdür. Kullanıcı çıktığında bu veriler kaybolur.
                FormsAuthentication.SetAuthCookie(sonuc.adminUserName, false);
                Session["adminUserName"]=admin.adminUserName;
                ViewBag.cinsiyet = admin.adminCinsiyet;
                return RedirectToAction("Index", "Business");
            }
            else
            {
                return RedirectToAction("LoginPanel");
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginPanel");
        }
    }
}