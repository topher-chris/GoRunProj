using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GoRunProj.Models
{
    public class RatedSpot
    {
        [Key]
        public int Id { get; set; }
        public int Rate { get; set; }
        public string LocationName { get; set; }
    }
}
