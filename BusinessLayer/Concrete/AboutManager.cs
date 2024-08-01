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
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;

		public AboutManager (IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void AboutAdd(About about)
		{
			_aboutDal.Add(about);
		}

		public void AboutRemove(About about)
		{
			_aboutDal.Remove(about);
		}

		public void AboutUpdate(About about)
		{
			_aboutDal.Update(about);
		}

		public IQueryable<About> GetAllBL()
		{
			return _aboutDal.GetAll();
		}

		public About GetById(int id)
		{
			return _aboutDal.GetById(x=>x.AboutId==id);
		}
	}
}
