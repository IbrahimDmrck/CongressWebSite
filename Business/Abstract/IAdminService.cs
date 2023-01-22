using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        void Add(Admin admin);
        void Delete(Admin admin);
        void Update(Admin admin);
        List<Admin> GetAll();
        Admin GetById(int id);
    }
}
