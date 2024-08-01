using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContentService
	{
		IQueryable<Content> GetAllById(int id);
		IQueryable<Content> GetAllBL();

		void ContentAdd (Content content);

		Content GetById (int id);

		void ContentUpdate (Content content);

		void ContentDelete (Content content);
	}
}
