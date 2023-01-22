using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Models
{
    public class AnnouncementModel
    {
        public int Id { get; set; }
        public IFormFile ImagePath { get; set; }
        public string AnnounceTitle { get; set; }
        public string AnnounceContent { get; set; }
        public DateTime AnnounceDate { get; set; }
    }
}
