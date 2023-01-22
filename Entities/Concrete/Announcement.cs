using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string AnnounceTitle { get; set; }
        public string AnnounceContent { get; set; }
        public DateTime AnnounceDate { get; set; }
    }
}
