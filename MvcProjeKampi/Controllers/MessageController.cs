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
    public class MessageController : Controller
    {
        MessageManager MessageManager = new MessageManager(new EfMessageDal());
        
        public ActionResult Inbox()
        {
            var MessageList = MessageManager.GetAllInbox();
            return View(MessageList);
        }

        public ActionResult Sendbox()
        {

            var MessageList = MessageManager.GetAllSendbox();
            return View(MessageList);
        }

         public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]

        public ActionResult NewMessage (Message message)
        {
			MessageValidator validationRules = new MessageValidator();
			ValidationResult results = validationRules.Validate(message);

			if (results.IsValid)
			{
                message.MessageDate = DateTime.Now;
				MessageManager.MessageAdd(message);
				return RedirectToAction("Sendbox");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
        public ActionResult  GetMessageInbox(int id)
        {
            var getValuesInbox = MessageManager.GetById(id);
            return View(getValuesInbox);
        }


        public ActionResult GetMessageSendbox(int id)
        {
            var getValuesSend = MessageManager.GetById(id);
            return View(getValuesSend);
        }
    }
}