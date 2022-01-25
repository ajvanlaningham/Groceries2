using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        public int MeasurementId { get; set; }
        [Required]
        public int RecipeId { get; set; }
        [Required]
        public int Quantity { get; set; }


        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
