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
    public class AnnouncementController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminAnnouncementGetAll()
        {
            var values = announcementManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminAnnouncementAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AdminAnnouncementAdd(AnnouncementModel announceModel)
        {
            Announcement announcement = new Announcement();
            if (announceModel.ImagePath!=null)
            {
                var extension = Path.GetExtension(announceModel.ImagePath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                announceModel.ImagePath.CopyTo(stream);
                announcement.ImagePath = newImageName;
                announcement.AnnounceTitle = announceModel.AnnounceTitle;
                announcement.AnnounceDate = announceModel.AnnounceDate;
                announcement.AnnounceContent = announceModel.AnnounceContent;
                announcementManager.Add(announcement);
            }
            return RedirectToAction("AdminAnnouncementGetAll", "Announcement");
        }

        public IActionResult AdminAnnouncementDelete(int id)
        {
            var announce = announcementManager.GetById(id);
            announcementManager.Delete(announce);
            return RedirectToAction("AdminAnnouncementGetAll", "Announcement");
        }

        [HttpGet]
        public IActionResult AdminAnnouncementUpdate(int id)
        {
            var announce = announcementManager.GetById(id);
            AnnouncementModel model = new AnnouncementModel
            {
                AnnounceContent = announce.AnnounceContent,
                AnnounceDate = announce.AnnounceDate,
                AnnounceTitle = announce.AnnounceTitle,
                Id = announce.Id
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AdminAnnouncementUpdate(AnnouncementModel announceModel)
        {
            
            var announcement = announcementManager.GetById(announceModel.Id);
            if (announceModel.ImagePath != null)
            {
                var extension = Path.GetExtension(announceModel.ImagePath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                announceModel.ImagePath.CopyTo(stream);
                announcement.ImagePath = newImageName;
                announcement.AnnounceTitle = announceModel.AnnounceTitle;
                announcement.AnnounceDate = announceModel.AnnounceDate;
                announcement.AnnounceContent = announceModel.AnnounceContent;
                announcementManager.Update(announcement);
              
            }
            return RedirectToAction("AdminAnnouncementGetAll", "Announcement");
        }

        [AllowAnonymous]
        public IActionResult AnnouncementGetAll()
        {
            var values = announcementManager.GetAll();
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult AnnouncementDetails(int id)
        {
            var announce = announcementManager.GetById(id);
            return View(announce);
        }
    }
}
