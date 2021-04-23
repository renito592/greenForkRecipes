using AutoMapper;
using GreenForkRecipes.Models;
using GreenForkRecipes.ViewModels.Auth;
using GreenForkRecipes.ViewModels.Profile;
using GreenForkRecipes.ViewModels.Recipe;
using GreenForkRecipes.ViewModels.RecipeComment;
using GreenForkRecipes.ViewModels.RecipeComments;
using GreenForkRecipes.ViewModels.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            //model to vm
            CreateMap<User, UserProfileDetailsVM>();
            CreateMap<User, UserProfileEditVM>()
                .ForMember(user => user.PictureFile, opt => opt.Ignore());
            CreateMap<Recipe, RecipeDetailsVM>()
                .ForMember(recipe => recipe.Comments, options => options.MapFrom(x => x.Comments));
            CreateMap<Recipe, RecipeEditVM>()
                 .ForMember(user => user.PictureFile, opt => opt.Ignore());
            CreateMap<RecipeComment, RecipeCommentEditVM>();
            CreateMap<RecipeComment, RecipeCommentDetailsVM>();
            CreateMap<User, UserProfileVM>();

            

            //vm to model
            CreateMap<UserProfileEditVM, User>();
            CreateMap<RegisterVM, User>();
            CreateMap<RecipeEditVM, Recipe>()
                .ForMember(recipe => recipe.Comments, options => options.Ignore())
                .ForMember(recipe => recipe.User, options => options.Ignore())
                .ForMember(recipe => recipe.UserId, options => options.MapFrom(x => AuthenticationService.LoggedUser.Id));
            CreateMap<RecipeCommentEditVM, RecipeComment>()
                .ForMember(recipe => recipe.UserId, options => options.MapFrom(x => AuthenticationService.LoggedUser.Id));
            CreateMap<UserProfileVM, User>();
                    
        }
    }
}
