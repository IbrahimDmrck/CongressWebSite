using Business.Concrete;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Controllers
{
    public class GeneralInformationController : Controller
    {
        GeneralInformationManager generalInformationManager = new GeneralInformationManager(new EfGeneralInformationDal());


        public IActionResult AdminGeneralInformationGetAll()
        {
            var values = generalInformationManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminGeneralInformationAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminGeneralInformationAdd(GeneralInformation generalInformation)
        {

            GeneralInformationValidator generalInfoValidator = new GeneralInformationValidator();
            ValidationResult result = generalInfoValidator.Validate(generalInformation);

            if (result.IsValid)
            {
                generalInformationManager.Add(generalInformation);
                return RedirectToAction("AdminGeneralInformationGetAll", "GeneralInformation");
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

        public IActionResult AdminGeneralInformationDelete(int id)
        {
            var generalInfo = generalInformationManager.GetById(id);
            generalInformationManager.Delete(generalInfo);
            return RedirectToAction("AdminGeneralInformationGetAll", "GeneralInformation");
        }

        [HttpGet]
        public IActionResult AdminGeneralInformationUpdate(int id)
        {
            var value = generalInformationManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult AdminGeneralInformationUpdate(GeneralInformation generalInformation)
        {

            GeneralInformationValidator generalInfoValidator = new GeneralInformationValidator();
            ValidationResult result = generalInfoValidator.Validate(generalInformation);

            if (result.IsValid)
            {
                generalInformationManager.Update(generalInformation);
                return RedirectToAction("AdminGeneralInformationGetAll", "GeneralInformation");
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

        [AllowAnonymous]
        public IActionResult GeneralInformationGetAll()
        {
            var values = generalInformationManager.GetAll();
            return View(values);
        }
    }
}
