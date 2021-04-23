using GreenForkRecipes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace GreenForkRecipes.Repositories.Abstraction
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel, new ()
    {
        protected readonly RecipesDbContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(RecipesDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public virtual void Delete(int id)
        {
            T t = GetById(id);
            dbSet.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T t)
        {
            dbSet.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            T element = GetById(t.Id);
            if (element != null)
            {
                context.Entry(element).State = EntityState.Detached;
            }
            context.Entry(t).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
