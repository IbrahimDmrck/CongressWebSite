using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TransportLayover
    {
        [Key]
        public int TransportId { get; set; }
        public string ImagePath { get; set; }
        public string Capacity { get; set; }
        public string MinDemand { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

    }
}
