using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongressWebSite.Models
{
    public class CongressModel
    {
        public int KongreId { get; set; }
        public IFormFile ImagePath { get; set; }
        public string KongreBaskani { get; set; }
        public string KongreDuzenlemeKurulu { get; set; }
        public string BilimKurulu { get; set; }
        public string KongreKonusu { get; set; }
        public string KongreAltKonu { get; set; }
        public string KongreAdi { get; set; }
        public string KongreHakkinda { get; set; }
        public string KongreAdresi { get; set; }
        public DateTime KongreTarihi { get; set; }
        public DateTime KongreBitisTarihi { get; set; }
    }
}
