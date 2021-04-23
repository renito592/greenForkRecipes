using GreenForkRecipes.Enums;
using GreenForkRecipes.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.Profile
{
    public class UserProfileEditVM : BaseVM
    {
        public string Username { get; set; }
        [MaxLength(40)]
        [MinLength(6, ErrorMessage = "Password must be longer than 3 characters")]
        public string Password { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(3, ErrorMessage = "First name must be longer than 3 characters")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(3, ErrorMessage = "Last name must be longer than 3 characters")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        public GenderValues Gender { get; set; }

        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }

        [MaxLength(500)]
        [MinLength(3)]
        [DisplayName("Biography")]
        public string Bio { get; set; }

        public int CookingPoints { get; set; }
    }
}
