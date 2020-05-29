using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GoRunProj.Models
{
    public class RunningSpot
    {
        

    [Key]
        public int Id { get; set; }

        //[StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }


        [Required]
        [Display(Name = "Location Type")]
        public string LocationType { get; set; }

        [Display(Name = "Will You Go Again?")]

        [Required]
        public string Choice { get; set; }

        public string Yes { get; set; }
        public string No { get; set; }
    }
}
