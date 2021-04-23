using GreenForkRecipes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels
{
    public class LoginVM : BaseVM
    {
        [Required]
        [MaxLength(40)]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        [MaxLength(40)]
        public string Password { get; set; }
    }
}
