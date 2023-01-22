using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.ViewComponents.Congress
{
    public class CongressHomeList : ViewComponent
    {
        CongressManager _congressManager=new CongressManager(new EfCongressDal());

     

        public IViewComponentResult Invoke()
        {
            var values = _congressManager.GetAll();
            return View(values);
        }
    }
}
