using DataAccess.Abstract;
using DataAccess.Repository.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfGeneralInformationDal : GenericRepositori<GeneralInformation>, IGeneralInformationDal
    {
    }
}
