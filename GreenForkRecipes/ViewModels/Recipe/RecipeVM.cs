
using GreenForkRecipes.Models;
using GreenForkRecipes.ViewModels.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.Recipes
{
    public class RecipeVM : BaseVM
    {
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        public string Picture { get; set; }

        [Required]
        public int UserId { get; set; }

        public UserProfileVM User { get; set; }
    }
}
