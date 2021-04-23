using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Services;
using GreenForkRecipes.Services.ModelServices;
using GreenForkRecipes.ViewModels;
using GreenForkRecipes.ViewModels.Auth;
using GreenForkRecipes.ViewModels.Profile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreenForkRecipes.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserService userService;
        private readonly ImageUploadService imageUploadService;
        public AuthController(UserService userService, ImageUploadService imageUploadService)
        {
            this.userService = userService;
            this.imageUploadService = imageUploadService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UserProfileEditVM user = userService.GetByUsernameAndPassword(model.Username, model.Password);
            if (user == null)
            {
                ModelState.AddModelError("Invalid data.", "Wrong username or password!");
                return View(model);
            }
            else
                AuthenticationService.LoggedUser = user;
            return RedirectToAction("Index","Recipe");
        }

        public IActionResult Logout()
        {
            AuthenticationService.LoggedUser = null;
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.PictureFile != null)
            {
                model.Picture = imageUploadService.UploadPicture(model.PictureFile);
            }
           
            userService.Insert(model);
            return RedirectToAction("Login");
              
        }

    }
}