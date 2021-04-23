using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories.Abstraction;
using GreenForkRecipes.Services.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Repositories
{
    public class RecipeRepository : BaseRepository<Recipe>
    {
        public RecipeRepository(RecipesDbContext context,FileHelperService fileHelperService,IWebHostEnvironment webHostEnvironment,AppSettings appSettings)
            : base(context)
        {
        }

        public List<Recipe> GetAllWithUser()
        {
           return  dbSet.Include(r => r.User).ToList();
        }

        public Recipe GetById(int id,int userId)
        {
            return dbSet.FirstOrDefault(r => r.Id == id && r.UserId == userId);
        }
        public Recipe GetByIdWithUser(int id)
        {
            return GetAllWithUser().FirstOrDefault(r => r.Id == id);
        }
        public List<Recipe> GetByUserId(int userId)
        {
            return GetAll().Where(r => r.UserId == userId).ToList();
        }
        public Recipe GetByIdWithComments(int id)
        {
            return dbSet.Include(r => r.Comments).FirstOrDefault(r => r.Id == id );
        }
        public override void Delete(int id)
        {
            context.RecipeComments.RemoveRange(GetByIdWithComments(id).Comments);
            base.Delete(id);
        }

    }
}
