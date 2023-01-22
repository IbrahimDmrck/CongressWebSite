using DataAccess.Abstract;
using DataAccess.Repository.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class EfAdminDal : GenericRepositori<Admin>, IAdminDal
    {
    }
}
