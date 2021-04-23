using GreenForkRecipes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Models
{
    public class User : BaseModel
    {
        [Required]
        [MaxLength(40)]
        [MinLength(3)]
        public string Username { get; set; }
        [Required]
        [MaxLength(40)]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Range(0,2)]
        public GenderValues Gender { get; set; }

        public string Picture { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; }
        [DefaultValue(0)]
        public int CookingPoints { get; set; }

        public ICollection<Recipe> Recipes { get; set; }

        public ICollection<RecipeComment> Comments { get; set; }
    }
}
