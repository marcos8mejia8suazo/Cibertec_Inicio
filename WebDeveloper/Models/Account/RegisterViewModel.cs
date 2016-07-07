﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =6)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="The Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
