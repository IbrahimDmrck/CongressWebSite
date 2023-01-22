using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminContactInfoManager : IAdminContactInfoService
    {
        IAdminContactInfoDal _AdminContactInfoDal;

        public AdminContactInfoManager(IAdminContactInfoDal adminContactInfoDal)
        {
            _AdminContactInfoDal = adminContactInfoDal;
        }

        public void Add(AdminContactInfo adminContact)
        {
            _AdminContactInfoDal.Add(adminContact);
        }

        public void Delete(AdminContactInfo adminContact)
        {
            _AdminContactInfoDal.Delete(adminContact);
        }

        public List<AdminContactInfo> GetAll()
        {
            return _AdminContactInfoDal.GetAll();
        }

        public AdminContactInfo GetById(int id)
        {
           return _AdminContactInfoDal.GetById(id);
        }

        public void Update(AdminContactInfo adminContact)
        {
            _AdminContactInfoDal.Update(adminContact);
        }
    }
}
