using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMessageService
	{
		IQueryable<Message> GetAllInbox();

		IQueryable<Message> GetAllSendbox();

		void MessageAdd (Message message);

		void MessageRemove (Message message);

		void MessageUpdate (Message message);

		Message GetById (int id);
	}
}
