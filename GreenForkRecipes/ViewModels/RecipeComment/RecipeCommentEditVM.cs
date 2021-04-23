using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.RecipeComment
{
    public class RecipeCommentEditVM : BaseVM
    {
        public int UserId { get; set; }

        public int RecipeId { get; set; }
        
        [Required]
        [Display(Name ="Give cooking point")]
        public bool Rating { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
