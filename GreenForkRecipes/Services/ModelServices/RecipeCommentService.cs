using AutoMapper;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Repositories.Abstraction;
using GreenForkRecipes.Services.ModelServices.Abstractions;
using GreenForkRecipes.ViewModels.RecipeComment;
using GreenForkRecipes.ViewModels.RecipeComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.ModelServices
{
    public class RecipeCommentService : BaseService<RecipeComment, RecipeCommentDetailsVM, RecipeCommentEditVM>
    {
        public RecipeCommentService(RecipeCommentRepository repository, IMapper mapper) : base(repository, mapper)
        {
            
        }
        
        public List<RecipeCommentDetailsVM> GetAllWithUserByRecipeId(int recipeId)
            {
                return ((RecipeCommentRepository)repository).GetAllWithUserByRecipeId(recipeId)
                    .Select(model => mapper.Map<RecipeComment, RecipeCommentDetailsVM>(model))
                    .ToList();
            }
    }
}
