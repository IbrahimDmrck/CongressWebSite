using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GeneralInformation 
    {
        [Key]
        public int Id { get; set; }
        public string SummaryContent { get; set; }
        public string PaperEvaluation { get; set; }
        public string Rules { get; set; }
    }
}
