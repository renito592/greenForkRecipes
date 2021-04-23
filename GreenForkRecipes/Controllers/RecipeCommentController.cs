using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Services;
using GreenForkRecipes.Services.ModelServices;
using GreenForkRecipes.ViewModels.Profile;
using GreenForkRecipes.ViewModels.RecipeComment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace GreenForkRecipes.Controllers
{
    public class RecipeCommentController : Controller
    {
        private RecipeCommentService recipeCommentService;
        private RecipeService recipeService;
        private UserService userService;
        public RecipeCommentController(RecipeCommentService recipeCommentService,RecipeService recipeService,UserService userService)
        {
            this.recipeCommentService = recipeCommentService;
            this.recipeService = recipeService;
            this.userService = userService;
        }

        public IActionResult Edit(int? id, int recipeId)
        {
            RecipeCommentEditVM createModel = new RecipeCommentEditVM()
                {
                RecipeId = recipeId,
                UserId = AuthenticationService.LoggedUser.Id
                };
            //create mode
            if (!id.HasValue)
            { 
                return PartialView(createModel);
            }
            RecipeCommentEditVM comment = recipeCommentService.GetById(id.Value);
            if (comment == null)
            {
                return PartialView(createModel);
            }

            //edit mode
            if (AuthenticationService.LoggedUser.Id == comment.UserId)
            {
            return PartialView(comment);
            }
            return PartialView(createModel);
        }


        [HttpPost]
        public IActionResult Edit(RecipeCommentEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Details", "Recipe", new { id = model.RecipeId });               
            }

            RecipeCommentEditVM comment = recipeCommentService.GetById(model.Id);
            //create mode
            if (comment == null)
            {
                
                recipeCommentService.Insert(model);
                UserProfileEditVM cooker = userService.GetById(recipeService.GetByIdWithUser(model.RecipeId).User.Id);
                cooker.CookingPoints+=Convert.ToInt32(model.Rating);
                userService.Update(cooker);

            }
            else//edit mode
            if (comment.UserId == AuthenticationService.LoggedUser.Id)
            {
                if (comment.Rating == false && model.Rating == true)
                {
                    UserProfileEditVM cooker = userService.GetById(recipeService.GetByIdWithUser(comment.RecipeId).User.Id);
                    cooker.CookingPoints += Convert.ToInt32(model.Rating);
                    userService.Update(cooker);
                }
                model.UserId = AuthenticationService.LoggedUser.Id;
                recipeCommentService.Update(model);
            }
            return RedirectToAction("Details", "Recipe", new { id = model.RecipeId });
        }

        public IActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index", "Recipe");
            }
            else
            {
                RecipeCommentEditVM comment = recipeCommentService.GetById(id.Value);
                if (comment == null)
                {
                    return RedirectToAction("Index", "Recipe");
                }
                else
                {
                    if (AuthenticationService.LoggedUser.Id == comment.UserId)
                    {
                        recipeCommentService.Delete(comment.Id);
                        UserProfileEditVM cooker = userService.GetById(recipeService.GetByIdWithUser(comment.RecipeId).User.Id);
                        cooker.CookingPoints -= Convert.ToInt32(comment.Rating);
                        userService.Update(cooker);
                        return RedirectToAction("Details", "Recipe", new { id = comment.RecipeId });
                    }
                    else
                        return RedirectToAction("Details", "Recipe", new { id = comment.RecipeId });
                }
            }

        }

    }
}