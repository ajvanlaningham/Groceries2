using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Cuisine { get; set; }
        [Required]
        public string Category { get; set; }



        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
