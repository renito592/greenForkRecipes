using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(RecipesDbContext context) : base(context)
        {
        }

        public User GetByUsernameAndPassword(string username,string password)
        {           
             return dbSet.FirstOrDefault(u => u.Password == password && u.Username == username);                
        }
    }
}
