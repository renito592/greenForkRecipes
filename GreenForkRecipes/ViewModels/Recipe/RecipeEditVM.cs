using GreenForkRecipes.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.Recipe
{
    public class RecipeEditVM : BaseVM
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

        [Required]
        public int UserId { get; set; }

        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }

    }
}
