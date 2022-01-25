﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public string Url { get; set; }



        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
