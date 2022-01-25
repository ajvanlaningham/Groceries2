using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Models
{
    public class Measurement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Unit { get; set; }
    }
}
