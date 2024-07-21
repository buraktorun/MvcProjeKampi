using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal =  categoryDal;
		}

		public void CategoryAddBL(Category category)
		{
			_categoryDal.Add(category);
		}

		public void CategoryRemove(Category category)
		{
			_categoryDal.Remove(category);
		}

		public void CategoryUpdate(Category category)
		{
			_categoryDal.Update(category);
		}

		public IQueryable<Category> GetAllBL()
		{
			return _categoryDal.GetAll();
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetById(x=>x.CategoryId==id);
		}
	}
}
