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
	public class HeadingManager : IHeadingService
	{
		IHeadingDal _HeadingDal;
		public HeadingManager(IHeadingDal headingDal) 
		
		{ 
			_HeadingDal = headingDal;
		}

		public Heading GetById(int id)
		{
			return _HeadingDal.GetById(x=>x.HeadingId==id);
		}

		public void HeadingAdd(Heading heading)
		{
			_HeadingDal.Add(heading);
		}

		public IQueryable<Heading> HeadingAll()
		{
			return _HeadingDal.GetAll();
		}

		public void HeadingRemove(Heading heading)
		{
			
			_HeadingDal.Update(heading);
		}

		public void HeadingUpdate(Heading heading)
		{
			 _HeadingDal.Update(heading);
		}
	}
}
