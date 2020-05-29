using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace GoRunProj.Models
{
    public class LocationOption
    {
        [Key]
        public int Id { get; set; }
        public string LocationName { get; set; }
    }
}
