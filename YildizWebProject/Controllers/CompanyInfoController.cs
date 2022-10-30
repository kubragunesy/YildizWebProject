using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YildizWebProject.Controllers
{
    public class CompanyInfoController : Controller
    {
        // GET: CompanyInfo
        CompanyInfoManager companyInfoManager = new CompanyInfoManager(new EfCompanyInfoDal());
        public ActionResult Index()
        {
            var degerler = companyInfoManager.GetAll();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniIletisimBilgisi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIletisimBilgisi(CompanyInfo companyInfo, HttpPostedFileBase logo)
        {
            
           try
            {

                if (logo != null && logo.ContentLength > 0)
                {
                    string path = Path.Combine(Server.MapPath("~/Icon"), Path.GetFileName(logo.FileName));
                    logo.SaveAs(path);
                    companyInfo.logo = logo.FileName;
                    companyInfoManager.Insert(companyInfo);
                }
                else
                {
                    return View();
                }

            }
            catch (Exception)
            {
                ViewBag.message = "Görsel seçilmedi";

            }

            return RedirectToAction("Index");
        }
        public ActionResult SilIletisimBilgisi(int id)
        {
            var companyInfo = companyInfoManager.Get(id);
            companyInfo.statu = false;
            companyInfoManager.Update(companyInfo);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult GuncelleIletisimBilgisi(int id)
        {
            var degerler = companyInfoManager.Get(id);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult GuncelleIletisimBilgisi (CompanyInfo companyInfo, HttpPostedFileBase logo)
        {
            try
            {

                if (logo != null && logo.ContentLength > 0)
                {
                    string path = Path.Combine(Server.MapPath("~/Icon"), Path.GetFileName(logo.FileName));
                    logo.SaveAs(path);
                    companyInfo.logo = logo.FileName;
                    companyInfoManager.Update(companyInfo);
                }
                else
                {
                    return View();
                }

            }
            catch (Exception)
            {
                ViewBag.message = "Görsel seçilmedi";

            }

            return RedirectToAction("Index");
        }

    }
}