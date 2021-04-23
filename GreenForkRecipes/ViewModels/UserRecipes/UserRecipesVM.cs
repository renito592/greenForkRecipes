using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.UserRecipes
{
    public class UserRecipesVM : BaseVM
    {
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        public string Picture { get; set; }
        public int UserId { get; set; }
    }
}
