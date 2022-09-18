using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YildizWebProject.Models.Entity;
using EntitiyLayer.Concrete;

namespace YildizWebProject.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Business
        BusinessManager businessManager = new BusinessManager(new EfBusinessDal());
        public ActionResult Index()
        {
            var degerler = businessManager.GetAll();
            return View(degerler);
        }
    }
}