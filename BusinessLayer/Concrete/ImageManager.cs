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
	public class ImageManager : IImageService
	{
		IImageDal _ImageDal;

		public ImageManager (IImageDal ImageDal)
		{
			_ImageDal = ImageDal;
		}

		public IQueryable<Image> GetAllImage()
		{
			return _ImageDal.GetAll();
		}
	}
}
