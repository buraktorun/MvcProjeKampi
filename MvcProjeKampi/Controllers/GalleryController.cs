using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        ImageManager ImageManager = new ImageManager(new EfImageDal());
        public ActionResult Index()
        {
            var ImageValues = ImageManager.GetAllImage();
            return View(ImageValues);
        }
    }
}