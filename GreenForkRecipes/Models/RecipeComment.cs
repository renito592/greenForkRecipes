using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Models
{
    public class RecipeComment : BaseModel
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

        [Required]
        public bool Rating { get; set; }

        [Required]
        public string Comment { get; set; }

    }
}
