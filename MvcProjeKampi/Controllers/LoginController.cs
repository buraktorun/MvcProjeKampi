using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
			
			return View();
        }

        [HttpPost]
		public ActionResult Index(Admin p)
        {

            var AdminInfo = adminManager.AdminInfo(p);
            if (AdminInfo != null)
            {
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }

            return View();
		}
	}
}