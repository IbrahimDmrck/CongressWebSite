using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.ViewComponents.ImportantDate
{
    public class ImportantSideDate : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());



        public IViewComponentResult Invoke()
        {
            var values = announcementManager.GetAll();
            return View(values);
        }
    }
}
