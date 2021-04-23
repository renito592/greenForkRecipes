using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GreenForkRecipes.Filters;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Services;
using GreenForkRecipes.Services.ModelServices;
using GreenForkRecipes.ViewModels.Profile;
using GreenForkRecipes.ViewModels.Recipe;
using GreenForkRecipes.ViewModels.RecipeComments;
using GreenForkRecipes.ViewModels.Recipes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GreenForkRecipes.Controllers
{

    public class RecipeController : Controller
    {

        private RecipeService recipeService;
        private UserService userService;
        private RecipeCommentService recipeCommentService;
        private ImageUploadService imageUploadService;
        public RecipeController(RecipeService recipeService, UserService userService, RecipeCommentService recipeCommentService, ImageUploadService imageUploadService)
        {
            this.recipeService = recipeService;
            this.userService = userService;
            this.recipeCommentService = recipeCommentService;
            this.imageUploadService = imageUploadService;
        }

        
        public IActionResult Index()
        {
            return View();
        }
        [AuthenticationFilter]
        public IActionResult List()
        {
            //this look like problem
            
            List<RecipeVM> model = recipeService.GetAllWithUser().Select(r => new RecipeVM
            {
                Id = r.Id,
                Picture = r.Picture,
                Title = r.Title,
                UserId = r.UserId,
                User = new UserProfileVM()
                {
                Id = r.User.Id,
                Username = r.User.Username,
                FirstName = r.User.FirstName,
                LastName = r.User.LastName
                }
            }).ToList();
                
            return View(model);
        }

        [AuthenticationFilter]
        public IActionResult Details(int? id)
        {
            
            if (!id.HasValue)
            {
                return RedirectToAction("List");
            }
            RecipeDetailsVM model = recipeService.GetByIdWithUser(id.Value);           
            if (model == null)
            {
                return RedirectToAction("List");
            }

            List<RecipeCommentDetailsVM> comments = recipeCommentService.GetAllWithUserByRecipeId(id.Value);
            model.Comments = comments;
           
            return View(model);
        }

        [AuthenticationFilter]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return View(new RecipeEditVM());
            }
            RecipeEditVM  model = recipeService.GetById(id.Value,AuthenticationService.LoggedUser.Id);
            if (model == null)
            {
                return RedirectToAction("List");
            }
            
            return View(model);
        }

        [AuthenticationFilter]
        [HttpPost]
        public IActionResult Edit(RecipeEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model.Id);
            }

            //create
            if (model.Id == 0)
            {
                if (model.PictureFile != null)
                {
                model.Picture = imageUploadService.UploadPicture(model.PictureFile);
                }

                model.UserId = AuthenticationService.LoggedUser.Id;

                recipeService.Insert(model);
            }


            //edit
            RecipeEditVM editModel = recipeService.GetById(model.Id,AuthenticationService.LoggedUser.Id);
            if (editModel == null)
            {
               return RedirectToAction("List");
            }
            if (model.PictureFile != null)
            {
                model.Picture = imageUploadService.UploadPicture(model.PictureFile);
                editModel.Picture = model.Picture;
            }
            else model.Picture = editModel.Picture;         
            
            recipeService.Update(model);
            return RedirectToAction("Details",new { id = model.Id});
        }

        [AuthenticationFilter]
        public IActionResult Delete(int? id,bool? profileRoute)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("List");
            }
            RecipeEditVM recipe = recipeService.GetById(id.Value, AuthenticationService.LoggedUser.Id);
            if (recipe == null)
            {
                return RedirectToAction("List");
            }

            recipeService.Delete(recipe.Id);

            if (profileRoute.HasValue)
            {
                if (profileRoute.Value)
                {
                    return RedirectToAction("Details", "Profile");
                }
            }
            return RedirectToAction("List");
        }

    }
}
