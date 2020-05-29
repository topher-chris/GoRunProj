using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GoRunProj.Models
{
    public class NewLocationDDL
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }
       
        [Display(Name = "Location Type")]
        public string LocationType { get; set; }

        [Display(Name = "Will You Go Again?")]

       
        public string Choice { get; set; }
    }
}
