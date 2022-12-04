using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVize.Models.Entity;

namespace WebVize.Controllers
{
    public class HomeController : Controller
    {
        DuyurularDal duyuruu = new DuyurularDal();
        AdminlerDal adminn = new AdminlerDal();
       
        //public ActionResult Index()
        //{
        //    UniDbContext cntxt = new UniDbContext();
        //    cntxt.Database.Create();
            

        //    return View();
        //}
       
        [HttpGet]
        public ActionResult Index()
        {
            var duyurularr = duyuruu.DuyuruGetAll().ToList();
            return View(duyurularr);
        }


        [HttpGet]
        public ActionResult AdminEkle() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(Adminler adminler)
        {
            adminn.Admin_Add(adminler);
            return View();
        }
        [HttpGet]
        public ActionResult DuyuruEkle()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult DuyuruEkle(Duyurular duyurular)
        {
            duyuruu.Duyuru_Add(duyurular);
            return View();
        }

    }
}