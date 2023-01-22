using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Models
{
    public class TransportLayoverModel
    {
        public int TransportId { get; set; }
        public IFormFile ImagePath { get; set; }
        public string Capacity { get; set; }
        public string MinDemand { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}
