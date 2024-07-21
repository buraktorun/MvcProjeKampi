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
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public IQueryable<Writer> GetAllBL()
		{
			return _writerDal.GetAll();
		}

		public Writer GetById(int id)
		{
			return _writerDal.GetById(x=> x.WriterId==id);
		}

		public void WriterAdd(Writer writer)
		{
			_writerDal.Add(writer);
		}

		public void WriterRemove(Writer writer)
		{
			_writerDal.Remove(writer);
		}

		public void WriterUpdate(Writer writer)
		{
			_writerDal.Update(writer);
		}
	}
}
