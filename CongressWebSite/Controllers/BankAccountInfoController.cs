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
    public class BankAccountInfoController : Controller
    {
        BankAccountInfoManager bankAccountInfoManager = new BankAccountInfoManager(new EfBankAccountInfoDal());


        public IActionResult AdminBankAccountInfoGetAll()
        {
            var values = bankAccountInfoManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminBankAccountInfoAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminBankAccountInfoAdd(BankAccountInfo bankAccountInfo)
        {

    
            BankAccountInfoValidator bankAccountInfoValidator = new BankAccountInfoValidator();
            ValidationResult result = bankAccountInfoValidator.Validate(bankAccountInfo);

            if (result.IsValid)
            {
                bankAccountInfoManager.Add(bankAccountInfo);
                return RedirectToAction("AdminBankAccountInfoGetAll", "BankAccountInfo");
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

        public IActionResult AdminBankAccountInfoDelete(int id)
        {
            var bankInfo = bankAccountInfoManager.GetById(id);
            bankAccountInfoManager.Delete(bankInfo);
            return RedirectToAction("AdminBankAccountInfoGetAll", "BankAccountInfo");
        }

        [HttpGet]
        public IActionResult AdminBankAccountInfoUpdate(int id)
        {
            var bankInfo = bankAccountInfoManager.GetById(id);
           
            return View(bankInfo);
        }

        [HttpPost]
        public IActionResult AdminBankAccountInfoUpdate(BankAccountInfo bankAccountInfo)
        {
            BankAccountInfoValidator bankAccountInfoValidator = new BankAccountInfoValidator();
            ValidationResult result = bankAccountInfoValidator.Validate(bankAccountInfo);

            if (result.IsValid)
            {
                bankAccountInfoManager.Update(bankAccountInfo);
                return RedirectToAction("AdminBankAccountInfoGetAll", "BankAccountInfo");
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
