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
	public class AdminManager : IAdminService
	{
		IAdminDal _AdminDal;

		public AdminManager (IAdminDal adminDal)
		{
			_AdminDal = adminDal;
		}
		
			
		public Admin AdminInfo(Admin p)
		{
			return _AdminDal.GetSingle(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
		}
	}
}
