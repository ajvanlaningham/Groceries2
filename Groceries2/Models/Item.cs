using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public  decimal Cost { get; set; }

        public int StoreID { get; set; }



        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
