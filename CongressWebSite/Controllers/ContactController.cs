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
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());


        public IActionResult AdminContactGetAll()
        {
            var values = contactManager.GetAll();
            return View(values);
        }

        public IActionResult AdminGetByIdContact(int id)
        {
            var contact = contactManager.GetById(id);
            return View(contact);
        }

        public IActionResult AdminDeleteContact(int id)
        {
            var contactValue = contactManager.GetById(id);
            contactManager.Delete(contactValue);
            return RedirectToAction("AdminContactGetAll", "Contact");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SendMessage(Contact contact)
        {
            ContactValidator contactValidator = new ContactValidator();
            ValidationResult result = contactValidator.Validate(contact);

            if (result.IsValid)
            {
                contactManager.Add(contact);
                return RedirectToAction("Home", "HomePage");
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
