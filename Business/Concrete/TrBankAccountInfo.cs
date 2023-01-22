using Business.Abstract;
using DataAccess.Abstract;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TrBankAccountInfoManager : ITrBankAccountInfoService
    {
        ITrBankAccountInfoDal _trBankAccountInfoDal;

        public TrBankAccountInfoManager(ITrBankAccountInfoDal trBankAccountInfoDal)
        {
            _trBankAccountInfoDal = trBankAccountInfoDal;
        }

        public void Add(TrBankAccountInfo trBank)
        {
            _trBankAccountInfoDal.Add(trBank);
        }

        public void Delete(TrBankAccountInfo trBank)
        {
            _trBankAccountInfoDal.Delete(trBank);
        }

        public List<TrBankAccountInfo> GetAll()
        {
           return _trBankAccountInfoDal.GetAll();
        }

        public TrBankAccountInfo GetById(int id)
        {
           return _trBankAccountInfoDal.GetById(id);
        }

        public void Update(TrBankAccountInfo trBank)
        {
            _trBankAccountInfoDal.Update(trBank);
        }
    }
}
