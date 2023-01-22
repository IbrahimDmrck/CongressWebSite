using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGeneralInformationService
    {
        void Add(GeneralInformation generalInformation);
        void Delete(GeneralInformation generalInformation);
        void Update(GeneralInformation generalInformation);
        List<GeneralInformation> GetAll();
        GeneralInformation GetById(int id);
    }
}
