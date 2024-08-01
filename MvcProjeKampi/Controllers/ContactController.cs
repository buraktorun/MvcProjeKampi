using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            var ContactValues = contactManager.GetAllBL();
            return View(ContactValues);
        }

        public ActionResult GetContactDetails (int id)
        {
            var ContactValues = contactManager.GetById(id);
            return View(ContactValues);
        }
    }
}