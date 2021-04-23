using GreenForkRecipes.ViewModels.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.RecipeComments
{
    public class RecipeCommentDetailsVM : BaseVM
    {
        public int UserId { get; set; }
        public  UserProfileVM User { get; set; }

        public int RecipeId { get; set; }

        [Required]
        public bool Rating { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
