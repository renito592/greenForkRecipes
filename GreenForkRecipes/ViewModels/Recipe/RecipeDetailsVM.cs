using GreenForkRecipes.Models;
using GreenForkRecipes.ViewModels.Profile;
using GreenForkRecipes.ViewModels.RecipeComments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.Recipes
{
    public class RecipeDetailsVM : BaseVM
    {
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required]
        public int CookTime { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Directions { get; set; }

        public string Picture { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<RecipeCommentDetailsVM> Comments { get; set; }
    }
}
