using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Username")]
        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool Rememberme { get; set; }
    }
}
