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
	public class ContentManager : IContentService
	{
		public IContentDal _ContentDal;

		public  ContentManager (IContentDal contentDal)
		{
			_ContentDal = contentDal;
		}
		public void ContentAdd(Content content)
		{
			_ContentDal.Add(content);
		}

		public void ContentDelete(Content content)
		{
			_ContentDal.Remove(content);
		}

		public void ContentUpdate(Content content)
		{
			_ContentDal.Update(content);
		}

		public IQueryable<Content> GetAllBL()
		{
			return _ContentDal.GetAll();
		}

		public IQueryable<Content> GetAllById(int id)
		{
			return _ContentDal.GetWhere(x => x.HeadingId == id);
		}

		public Content GetById(int id)
		{
			return	_ContentDal.GetById(x => x.ContentId == id);
		}
	}
}
