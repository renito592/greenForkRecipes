using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Models
{
    public class Recipe : BaseModel
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

        public ICollection<RecipeComment> Comments { get; set; }
    }
}
