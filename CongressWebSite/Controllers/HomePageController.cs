using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Controllers
{
    public class HomePageController : Controller
    {
        CongressManager congressManager = new CongressManager(new EfCongressDal());

        [AllowAnonymous]
        public IActionResult Home()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult CongressDetails(int id)
        {
            var congress = congressManager.GetById(id);
            return View(congress);
        }

        [AllowAnonymous]
        public IActionResult CongressesGetAll()
        {
            var values = congressManager.GetAll();
            return View(values);
        }

        
    }
}
