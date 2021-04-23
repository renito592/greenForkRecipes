using GreenForkRecipes.Models;
using GreenForkRecipes.ViewModels.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services
{
    public static class AuthenticationService
    {
        public static UserProfileEditVM LoggedUser { get; set; }
    }
}
