using GreenForkRecipes.Enums;
using GreenForkRecipes.Models;
using GreenForkRecipes.ViewModels.Recipes;
using GreenForkRecipes.ViewModels.UserRecipes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.Profile
{
    public class UserProfileDetailsVM : BaseVM
    {
        [Required]
        [MaxLength(40)]
        public string Username { get; set; }
        public string Password { get; set; }
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Range(0, 2)]
        public GenderValues Gender { get; set; }

        public string Picture { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; }

        public int CookingPoints { get; set; }

       public  List<UserRecipesVM> Recipes { get; set; }

    }
}
