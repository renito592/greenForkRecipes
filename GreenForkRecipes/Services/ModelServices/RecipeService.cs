using AutoMapper;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Repositories.Abstraction;
using GreenForkRecipes.Services.ModelServices.Abstractions;
using GreenForkRecipes.ViewModels.Recipe;
using GreenForkRecipes.ViewModels.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.ModelServices
{
    public class RecipeService : BaseService<Recipe, RecipeDetailsVM, RecipeEditVM>
    {
        public RecipeService(RecipeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public List<RecipeDetailsVM> GetAllWithUser()
        {
            return ((RecipeRepository)repository).GetAllWithUser()
                .Select(model => mapper.Map<Recipe, RecipeDetailsVM>(model))
                .ToList();
        }

        public RecipeEditVM GetById(int id, int userId)
        {
            Recipe recipe = ((RecipeRepository)repository).GetById(id, userId);
            return mapper.Map<RecipeEditVM>(recipe);
        }

        public RecipeDetailsVM GetByIdWithUser(int id)
        {
            Recipe recipe = ((RecipeRepository)repository).GetByIdWithUser(id);
            return mapper.Map<RecipeDetailsVM>(recipe);
        }

        public List<RecipeDetailsVM> GetByUserId(int userId)
        {
            return ((RecipeRepository)repository).GetByUserId(userId)
                .Select(model => mapper.Map<Recipe, RecipeDetailsVM>(model))
                .ToList();
        }

        public RecipeDetailsVM GetByIdWithComments(int id)
        {
            Recipe recipe = ((RecipeRepository)repository).GetByIdWithComments(id);
            return mapper.Map<RecipeDetailsVM>(recipe);
        }

        public override void Delete(int id)
        {
            ((RecipeRepository)repository).Delete(id);
        }
    }
}
