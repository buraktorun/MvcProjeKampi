using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContactService
	{
		IQueryable<Contact> GetAllBL();

		void contactAdd (Contact contact);

		void contactRemove (Contact contact);

		void contactUpdate (Contact contact);

		Contact GetById (int id);
	}
}
