using Business.Concrete;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Controllers
{
    public class AdminContactInfoController : Controller
    {
        AdminContactInfoManager contactInfoManager = new AdminContactInfoManager(new EfAdminContactInfoDal());
        public IActionResult AdminContactInfoGetAll()
        {
            var values = contactInfoManager.GetAll();
            return View(values);
        }

        public IActionResult AdminContactInfoDelete(int id)
        {
            var contactInfo = contactInfoManager.GetById(id);
            contactInfoManager.Delete(contactInfo);
            return RedirectToAction("AdminContactInfoGetAll", "AdminContactInfo");
        }

        [HttpGet]
        public IActionResult AdminContactInfoUpdate(int id)
        {
            var contactInfo = contactInfoManager.GetById(id);

            return View(contactInfo);
        }

        [HttpPost]
        public IActionResult AdminContactInfoUpdate(AdminContactInfo contactInfo)
        {


            AdminContactInfoValidator contactInfoValidator = new AdminContactInfoValidator();
            ValidationResult result = contactInfoValidator.Validate(contactInfo);

            if (result.IsValid)
            {
                contactInfoManager.Update(contactInfo);
                return RedirectToAction("AdminContactInfoGetAll", "AdminContactInfo");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


           
        }

        [HttpGet]
        public IActionResult AdminContactInfoAdd()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AdminContactInfoAdd(AdminContactInfo contactInfo)
        {
            AdminContactInfoValidator contactInfoValidator = new AdminContactInfoValidator();
            ValidationResult result = contactInfoValidator.Validate(contactInfo);

            if (result.IsValid)
            {
                contactInfoManager.Add(contactInfo);
                return RedirectToAction("AdminContactInfoGetAll", "AdminContactInfo");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

          
        }
    }
}
