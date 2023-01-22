using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBankAccountInfoService
    {
        void Add(BankAccountInfo bankAccount);
        void Delete(BankAccountInfo bankAccount);
        void Update(BankAccountInfo bankAccount);
        List<BankAccountInfo> GetAll();
        BankAccountInfo GetById(int id);
    }
}
