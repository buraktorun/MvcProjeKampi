using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICategoryService
	{
		IQueryable<Category> GetAllBL();

		void CategoryAddBL (Category category);

		Category GetById(int id);

		void CategoryRemove(Category category);

		void CategoryUpdate(Category category);
	}
}
