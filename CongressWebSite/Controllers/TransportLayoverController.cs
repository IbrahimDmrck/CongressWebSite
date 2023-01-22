using Business.Concrete;
using CongressWebSite.Models;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Controllers
{
    public class TransportLayoverController : Controller
    {
        TransportLayoverManager transportLayoverManager = new TransportLayoverManager(new EfTransportLayoverDal());


        public IActionResult AdminTransportLayoverGetAll()
        {
            var values = transportLayoverManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminTransportLayoverAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminTransportLayoverAdd(TransportLayoverModel transportModel)
        {


            TransportLayover transport = new TransportLayover();
            if (transportModel.ImagePath != null)
            {
                var extension = Path.GetExtension(transportModel.ImagePath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                transportModel.ImagePath.CopyTo(stream);
                transport.ImagePath = newImageName;
                transport.MinDemand = transportModel.MinDemand;
                transport.Price = transportModel.Price;
                transport.Capacity = transportModel.Capacity;
                transport.Description = transportModel.Description;
                transportLayoverManager.Add(transport);
               

            }
            return RedirectToAction("AdminTransportLayoverGetAll", "TransportLayover");
        }

        public IActionResult AdminTransportLayoverDelete(int id)
        {
            var transport = transportLayoverManager.GetById(id);
            transportLayoverManager.Delete(transport);
            return RedirectToAction("AdminTransportLayoverGetAll", "TransportLayover");
        }


        [HttpGet]
        public IActionResult AdminTransportLayoverUpdate(int id)
        {
            var transport = transportLayoverManager.GetById(id);
            TransportLayoverModel model = new TransportLayoverModel
            {
                Capacity = transport.Capacity,
                Description = transport.Description,
                MinDemand = transport.MinDemand,
                Price = transport.Price,
                TransportId = transport.TransportId
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AdminTransportLayoverUpdate(TransportLayoverModel transportModel)
        {
            var transport = transportLayoverManager.GetById(transportModel.TransportId);
            if (transportModel.ImagePath != null)
            {
                var extension = Path.GetExtension(transportModel.ImagePath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                transportModel.ImagePath.CopyTo(stream);
                transport.ImagePath = newImageName;
                transport.MinDemand = transportModel.MinDemand;
                transport.Price = transportModel.Price;
                transport.Capacity = transportModel.Capacity;
                transport.Description = transportModel.Description;
                transportLayoverManager.Update(transport);
               

            }
            return RedirectToAction("AdminTransportLayoverGetAll", "TransportLayover");
        }

        [AllowAnonymous]
        public IActionResult TransportLayoversGetAll()
        {
            var values = transportLayoverManager.GetAll();
            return View(values);
        }
    }
}
