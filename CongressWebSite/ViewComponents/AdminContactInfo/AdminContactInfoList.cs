using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.ViewComponents.AdminContactInfo
{
    public class AdminContactInfoList : ViewComponent
    {
        AdminContactInfoManager _adminContactInfo = new AdminContactInfoManager(new EfAdminContactInfoDal());



        public IViewComponentResult Invoke()
        {
            var values = _adminContactInfo.GetAll();
            return View(values);
        }
    }
}
