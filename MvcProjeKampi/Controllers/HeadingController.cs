using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager WriterManager = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var GetAll = hm.HeadingAll();

            return View(GetAll);
        }

        public ActionResult AddHeading()
        {
            List<SelectListItem> ValueCategory = (from x in categoryManager.GetAllBL()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();

            ViewBag.ValueCategory = ValueCategory;

            List<SelectListItem> ValueWriter = (from x in WriterManager.GetAllBL()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.WriterName + " " + x.WriterSurName,
                                                          Value = x.WriterId.ToString()

                                                      }).ToList();
            ViewBag.ValueWriter = ValueWriter;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate =DateTime.Now;
            hm.HeadingAdd(heading);
            return RedirectToAction("Index");
        }

        public ActionResult EditHeading(int id )
        {
			List<SelectListItem> ValueCategory = (from x in categoryManager.GetAllBL()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryId.ToString()
												  }).ToList();

			ViewBag.ValueCategory = ValueCategory;

            
			var HeadingValue = hm.GetById (id);
            return View(HeadingValue);

        }

        [HttpPost]
        public ActionResult EditHeading (Heading heading)
        {
            HeadingValidator validationRules = new HeadingValidator();
            ValidationResult Result = validationRules.Validate(heading);
            
            if (Result.IsValid)
            {
				
				hm.HeadingUpdate(heading);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in Result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteHeading (int id)
        {
            var HeadingValue = hm.GetById(id);
            HeadingValue.HeadingStatus = false;
            hm.HeadingRemove(HeadingValue);
            return RedirectToAction ("Index");
        }
    }

    
}