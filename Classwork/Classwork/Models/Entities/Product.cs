using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Classwork.Models.Entities
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please put your name")]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string Description { get; set; }
    }
}