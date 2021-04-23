using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenForkRecipes.Filters;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Services;
using GreenForkRecipes.Services.ModelServices;
using GreenForkRecipes.ViewModels.Profile;
using GreenForkRecipes.ViewModels.Recipes;
using GreenForkRecipes.ViewModels.UserRecipes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GreenForkRecipes.Controllers
{
    [AuthenticationFilter]
    public class ProfileController : Controller
    {
        private UserService userService;
        private RecipeService recipeService;
        private ImageUploadService imageUploadService;
        public ProfileController(UserService userService,RecipeService recipeService,ImageUploadService imageUploadService)
        {
            this.userService = userService;
            this.recipeService = recipeService;
            this.imageUploadService = imageUploadService;
        }
        public IActionResult Details(int? id)
        {
            UserProfileDetailsVM model;
            if (!id.HasValue)
            {
            model = userService.GetDetails(AuthenticationService.LoggedUser.Id);
            }
            else
            { 
            model = userService.GetDetails(id.Value);
            }

            if (model == null)
            {
               return RedirectToAction("Index", "Recipe");
            }
            List<UserRecipesVM> userRecipes = recipeService.GetByUserId(model.Id).Select(r => new UserRecipesVM()
            {
                Id = r.Id,
                Picture = r.Picture,
                Title = r.Title,
                UserId = r.UserId
            })
            .ToList();
            model.Recipes = userRecipes;
            return View(model);
        }

        public IActionResult Edit()
        {

            UserProfileEditVM model = new UserProfileEditVM()
            {
                Id = AuthenticationService.LoggedUser.Id,
                Username = AuthenticationService.LoggedUser.Username,
                Password = AuthenticationService.LoggedUser.Password,
                FirstName = AuthenticationService.LoggedUser.FirstName,
                LastName = AuthenticationService.LoggedUser.LastName,
                Gender = AuthenticationService.LoggedUser.Gender,
                Bio = AuthenticationService.LoggedUser.Bio,
                Picture = AuthenticationService.LoggedUser.Picture
            };
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UserProfileEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.Password == null)
            {
                model.Password = AuthenticationService.LoggedUser.Password;
            }
            
            if (model.PictureFile != null)
            {
                model.Picture = imageUploadService.UploadPicture(model.PictureFile);
            }
            else model.Picture = AuthenticationService.LoggedUser.Picture;


            model.Id = AuthenticationService.LoggedUser.Id;
            model.Username = AuthenticationService.LoggedUser.Username;
            model.CookingPoints = AuthenticationService.LoggedUser.CookingPoints;
           
            userService.Update(model);
            AuthenticationService.LoggedUser = model;
            return RedirectToAction("Details");
        }
    }
}