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
    public class GeneralInformationManager : IGeneralInformationService
    {
        IGeneralInformationDal _generalInformationDal;

        public GeneralInformationManager(IGeneralInformationDal generalInformationDal)
        {
            _generalInformationDal = generalInformationDal;
        }

        public void Add(GeneralInformation generalInformation)
        {
            _generalInformationDal.Add(generalInformation);
        }

        public void Delete(GeneralInformation generalInformation)
        {
            _generalInformationDal.Delete(generalInformation);
        }

        public List<GeneralInformation> GetAll()
        {
            return _generalInformationDal.GetAll();
        }

        public GeneralInformation GetById(int id)
        {
            return _generalInformationDal.GetById(id);
        }

        public void Update(GeneralInformation generalInformation)
        {
            _generalInformationDal.Update(generalInformation);
        }
    }
}
