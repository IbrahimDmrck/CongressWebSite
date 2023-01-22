using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITrBankAccountInfoService
    {
        void Add(TrBankAccountInfo trBank);
        void Delete(TrBankAccountInfo trBank);
        void Update(TrBankAccountInfo trBank);
        List<TrBankAccountInfo> GetAll();
        TrBankAccountInfo GetById(int id);
    }
}
