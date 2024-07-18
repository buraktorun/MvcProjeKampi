using DataAccessLayer.Conrete;
using DataAccessLayer.Conrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager
	{
		GenericRepository<Category> repo = new GenericRepository<Category>();

		public IQueryable<Category> GetAllBL()
		{
			return repo.GetAll();
		}

		public void CategoryAddBL(Category c)
		{
			repo.Add(c);
		}
	}
}
