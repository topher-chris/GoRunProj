using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoRunProj.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Address { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public float Lat { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public float Lng { get; set; }
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }


        [ForeignKey("Id")]
        public RunningSpot RunningSpot { get; set; }
    }
}
