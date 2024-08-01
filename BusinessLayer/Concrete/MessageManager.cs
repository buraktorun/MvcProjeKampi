using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

	public class MessageManager : IMessageService
	{
		IMessageDal _messageDal;

		public MessageManager (IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}
		public IQueryable<Message> GetAllInbox()
		{
			return _messageDal.GetWhere(x => x.ReceiverMail == "admin@gmail.com");
		}

		public IQueryable<Message> GetAllSendbox()
		{
			return _messageDal.GetWhere(x => x.SenderMail == "admin@gmail.com");
		}

		public Message GetById(int id)
		{
			return _messageDal.GetById(x=>x.MessageId==id);
		}

		public void MessageAdd(Message message)
		{
			_messageDal.Add(message);
		}

		public void MessageRemove(Message message)
		{
			_messageDal.Remove(message);
		}

		public void MessageUpdate(Message message)
		{
			_messageDal.Update(message);
		}
	}
}
