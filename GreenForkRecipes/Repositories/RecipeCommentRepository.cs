using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Repositories
{
    public class RecipeCommentRepository : BaseRepository<RecipeComment>
    {
        public RecipeCommentRepository(RecipesDbContext context) : base(context)
        {
        }

        public List<RecipeComment> GetAllWithUserByRecipeId(int recipeId)
        {
            return dbSet.Include(rc => rc.User).Where(rc => rc.RecipeId == recipeId).ToList();
        }
    }
}
