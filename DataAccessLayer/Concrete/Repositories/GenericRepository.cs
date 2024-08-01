using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conrete.Repositories
{
	public class GenericRepository<T> : IRepository<T> where T : class
	{
		Context context = new Context();
		DbSet<T> Table;

		public GenericRepository()
		{
			Table = context.Set<T>();
		}


		// READ REPOSITORY
		public IQueryable<T> GetAll() //LİSTELEME
			=> Table;


		public T GetSingle(Expression<Func<T, bool>> method) // İLK OLANI GETİR
			=> Table.FirstOrDefault(method);

		public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) // ŞARTLI LİSTELEME
			=> Table.Where(method);

		// WRITE REPOSITORY
		public void Add(T model) // INSERT
		{
			var AddEntity = context.Entry(model);
			AddEntity.State = EntityState.Added;
			context.SaveChanges();
		}

		public void AddRange(List<T> model) // TOPLU EKLEME
		{
			Table.AddRange(model);
		}

		public void Remove(T model) // DELETE
		{
			var removeEntity = context.Entry(model);
			removeEntity.State = EntityState.Deleted;
			context.SaveChanges();
		}

		public void RemoveRange(List<T> model) // TOPLU DELETE
		{
			Table.RemoveRange(model);
		}

		public void Update(T model) // UPDATE GUNCELLEME
		{
			var updateEntity = context.Entry(model);
			updateEntity.State = EntityState.Modified;
			context.SaveChanges();

		}


		public T GetById(Expression<Func<T, bool>> method)
		{
			return Table.SingleOrDefault(method);
		}

	}
}