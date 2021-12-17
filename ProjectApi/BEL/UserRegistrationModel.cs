﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class UserRegistrationModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please put your name")]
        [MinLength(5)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please put email Address")]
        [MinLength(5)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public double Balance { get; set; }
        public int Role { get; set; }
        public string RegTime { get; set; }
    }
}
