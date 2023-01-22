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
    public class BankAccountInfoManager : IBankAccountInfoService
    {
        IBankAccountInfoDal _bankAccountInfoDal;

        public BankAccountInfoManager(IBankAccountInfoDal bankAccountInfoDal)
        {
            _bankAccountInfoDal = bankAccountInfoDal;
        }

        public void Add(BankAccountInfo bankAccount)
        {
            _bankAccountInfoDal.Add(bankAccount);
        }

        public void Delete(BankAccountInfo bankAccount)
        {
            _bankAccountInfoDal.Delete(bankAccount);
        }

        public List<BankAccountInfo> GetAll()
        {
           return  _bankAccountInfoDal.GetAll();
        }

        public BankAccountInfo GetById(int id)
        {
          return _bankAccountInfoDal.GetById(id);
        }

        public void Update(BankAccountInfo bankAccount)
        {
            _bankAccountInfoDal.Update(bankAccount);
        }
    }
}
