using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IRepository<T> where T : class
	{
		
		// Read Repository
		IQueryable<T> GetAll();

		IQueryable<T> GetWhere(Expression<Func <T, bool>>method);

		T GetSingle (Expression<Func <T, bool>>method);

		T GetById (Expression<Func <T, bool>>method);

		//Write Repository
		void Add(T model);

		void AddRange(List<T> model);

		void Remove (T model);

		void RemoveRange (List<T> model);

		void Update (T model);

		
		
	}
}
