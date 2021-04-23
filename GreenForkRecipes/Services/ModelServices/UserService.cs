using AutoMapper;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Repositories.Abstraction;
using GreenForkRecipes.Services.ModelServices.Abstractions;
using GreenForkRecipes.ViewModels.Auth;
using GreenForkRecipes.ViewModels.Profile;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.ModelServices
{
    public class UserService : BaseService<User, UserProfileDetailsVM, UserProfileEditVM>
    {
        public UserService(UserRepository repository, IMapper mapper) : base(repository, mapper)
        {
           
        }

        public UserProfileEditVM GetByUsernameAndPassword(string username,string password)
        {
            User user = ((UserRepository)repository).GetByUsernameAndPassword(username, password);
            return mapper.Map<User, UserProfileEditVM>(user);
        }

        public void Insert(RegisterVM vm)
        {
            User user = mapper.Map<User>(vm);
            repository.Insert(user);
        }
    }
}
