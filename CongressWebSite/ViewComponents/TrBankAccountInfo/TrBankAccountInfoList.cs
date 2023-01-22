using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.ViewComponents.TrBankAccountInfo
{
    public class TrBankAccountInfoList : ViewComponent
    {
        TrBankAccountInfoManager trBankAccountInfo = new TrBankAccountInfoManager(new EfTrBankAccountInfoDal());



        public IViewComponentResult Invoke()
        {
            var values = trBankAccountInfo.GetAll();
            return View(values);
        }
    }
}
