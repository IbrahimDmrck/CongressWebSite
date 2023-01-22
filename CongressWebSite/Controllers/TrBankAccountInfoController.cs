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
    public class TrBankAccountInfoController : Controller
    {
        TrBankAccountInfoManager trbankAccountInfoManager = new TrBankAccountInfoManager(new EfTrBankAccountInfoDal());

        public IActionResult AdminTrBankAccountInfoGetAll()
        {
            var values = trbankAccountInfoManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminTrBankAccountInfoAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminTrBankAccountInfoAdd(TrBankAccountInfo trBank)
        {
            TrBankAccountInfoValidator trBankValidator = new TrBankAccountInfoValidator();
            ValidationResult result = trBankValidator.Validate(trBank);

            if (result.IsValid)
            {
                trbankAccountInfoManager.Add(trBank);
                return RedirectToAction("AdminTrBankAccountInfoGetAll", "TrBankAccountInfo");
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

        public IActionResult AdminTrBankAccountInfoDelete(int id)
        {
            var trbank = trbankAccountInfoManager.GetById(id);
            trbankAccountInfoManager.Delete(trbank);
            return RedirectToAction("AdminTrBankAccountInfoGetAll", "TrBankAccountInfo");
        }

        [HttpGet]
        public IActionResult AdminTrBankAccountInfoUpdate(int id)
        {
            var value = trbankAccountInfoManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult AdminTrBankAccountInfoUpdate(TrBankAccountInfo trBank)
        {
            TrBankAccountInfoValidator trBankValidator = new TrBankAccountInfoValidator();
            ValidationResult result = trBankValidator.Validate(trBank);

            if (result.IsValid)
            {
                trbankAccountInfoManager.Update(trBank);
                return RedirectToAction("AdminTrBankAccountInfoGetAll", "TrBankAccountInfo");
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
