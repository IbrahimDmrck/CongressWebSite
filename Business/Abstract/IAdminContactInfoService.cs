using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminContactInfoService
    {
        void Add(AdminContactInfo adminContact);
        void Delete(AdminContactInfo adminContact);
        void Update(AdminContactInfo adminContact);
        List<AdminContactInfo> GetAll();
        AdminContactInfo GetById(int id);
    }
}
