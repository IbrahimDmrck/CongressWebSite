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
    public class SaveController : Controller
    {

        SaveManager saveManager = new SaveManager(new EfSaveDal());


        public IActionResult AdminSaveGetAll()
        {
            var values = saveManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminSaveAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminSaveAdd(Save save)
        {
            SaveValidator saveValidator = new SaveValidator();
            ValidationResult result = saveValidator.Validate(save);

            if (result.IsValid)
            {
                saveManager.Add(save);
                return RedirectToAction("AdminSaveGetAll", "Save");
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

        public IActionResult AdminSaveDelete(int id)
        {
            var value = saveManager.GetById(id);
            saveManager.Delete(value);
            return RedirectToAction("AdminSaveGetAll", "Save");
        }

        [HttpGet]
        public IActionResult AdminSaveUpdate(int id)
        {
            var save = saveManager.GetById(id);
            return View(save);
        }

        [HttpPost]
        public IActionResult AdminSaveUpdate(Save save)
        {
            SaveValidator saveValidator = new SaveValidator();
            ValidationResult result = saveValidator.Validate(save);

            if (result.IsValid)
            {
                saveManager.Update(save);
                return RedirectToAction("AdminSaveGetAll", "Save");
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
        public IActionResult SaveGetAll() 
        {
            var values = saveManager.GetAll();
            return View(values);
        }
    }
}
