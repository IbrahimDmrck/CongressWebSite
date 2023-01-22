using Business.Concrete;
using CongressWebSite.Models;
using DataAccess.Concrete.Context;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CongressWebSite.Controllers
{
    public class AdminPageController : Controller
    {
        CongressManager congressManager = new CongressManager(new EfCongressDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminCongressGetAll()
        {
            var values = congressManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminCongressAdd()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AdminCongressAdd(CongressModel congressModel)
        {
            Congress congress = new Congress();
            if (congressModel.ImagePath != null)
            {
                var extension = Path.GetExtension(congressModel.ImagePath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                congressModel.ImagePath.CopyTo(stream);
                congress.ImagePath = newImageName;
                congress.KongreAdi = congressModel.KongreAdi;
                congress.KongreAdresi = congressModel.KongreAdresi;
                congress.KongreBaskani = congressModel.KongreBaskani;
                congress.KongreBitisTarihi = congressModel.KongreBitisTarihi;
                congress.KongreDuzenlemeKurulu = congressModel.KongreDuzenlemeKurulu;
                congress.KongreHakkinda = congressModel.KongreHakkinda;
                congress.KongreKonusu = congressModel.KongreKonusu;
                congress.KongreTarihi = congressModel.KongreTarihi;
                congress.BilimKurulu = congressModel.BilimKurulu;
                congress.KongreAltKonu = congressModel.KongreAltKonu;
                congressManager.Add(congress);
                

            }
            return RedirectToAction("AdminCongressGetAll", "AdminPage");
        }

        public IActionResult AdminCongressDelete(int id)
        {
            var congress = congressManager.GetById(id);
            congressManager.Delete(congress);
            return RedirectToAction("AdminCongressGetAll", "AdminPage");
        }

        [HttpGet]
        public IActionResult AdminCongressUpdate(int id)
        {
            var congress = congressManager.GetById(id);

            CongressModel model = new CongressModel
            {
                KongreAdi = congress.KongreAdi,
                BilimKurulu = congress.BilimKurulu,
                KongreAltKonu = congress.KongreAltKonu,
                KongreBaskani = congress.KongreBaskani,
                KongreAdresi = congress.KongreAdresi,
                KongreBitisTarihi = congress.KongreBitisTarihi,
                KongreDuzenlemeKurulu = congress.KongreDuzenlemeKurulu,
                KongreHakkinda = congress.KongreHakkinda,
                KongreId = congress.KongreId,
                KongreKonusu = congress.KongreKonusu,
                KongreTarihi = congress.KongreTarihi
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AdminCongressUpdate(CongressModel congressModel)
        {
            var congress = congressManager.GetById(congressModel.KongreId);
            if (congressModel.ImagePath != null)
            {
                var extension = Path.GetExtension(congressModel.ImagePath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                congressModel.ImagePath.CopyTo(stream);
                congress.ImagePath = newImageName;
                congress.KongreAdi = congressModel.KongreAdi;
                congress.KongreAdresi = congressModel.KongreAdresi;
                congress.KongreBaskani = congressModel.KongreBaskani;
                congress.KongreBitisTarihi = congressModel.KongreBitisTarihi;
                congress.KongreDuzenlemeKurulu = congressModel.KongreDuzenlemeKurulu;
                congress.KongreHakkinda = congressModel.KongreHakkinda;
                congress.KongreKonusu = congressModel.KongreKonusu;
                congress.KongreTarihi = congressModel.KongreTarihi;
                congress.BilimKurulu = congressModel.BilimKurulu;
                congress.KongreAltKonu = congressModel.KongreAltKonu;
                congressManager.Update(congress);
               
            }
            return RedirectToAction("AdminCongressGetAll", "AdminPage");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
            CongressContext context = new CongressContext();
            var adminInfo = context.Admins.FirstOrDefault(x => x.Email == admin.Email && x.Password == admin.Password);
            if (adminInfo != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email,admin.Email)
                };

                var userIdentity = new ClaimsIdentity(claims, "admin");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "AdminPage");
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "AdminPage");
        }

    }
}
