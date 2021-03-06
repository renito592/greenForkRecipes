using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.ViewModels.Profile
{
    public class UserProfileVM : BaseVM
    {
        public string Username { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Picture { get; set; }
    }
}
