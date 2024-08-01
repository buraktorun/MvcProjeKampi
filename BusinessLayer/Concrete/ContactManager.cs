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
	public class ContactManager : IContactService
	{
		IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void contactAdd(Contact contact)
		{
			_contactDal.Add(contact);
		}

		public void contactRemove(Contact contact)
		{
			_contactDal.Remove(contact);
		}

		public void contactUpdate(Contact contact)
		{
			_contactDal.Update(contact);
		}

		public IQueryable<Contact> GetAllBL()
		{
			return _contactDal.GetAll();
		}

		public Contact GetById(int id)
		{
			return _contactDal.GetById(x => x.ContactId == id);
		}
	}
}
