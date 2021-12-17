﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class UserLoginModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email Address")]
        [MinLength(5)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        [MinLength(6)]
        public string Password { get; set; }

        public double Balance { get; set; }
        public int Role { get; set; }
        public string RegTime { get; set; }
    }
}
