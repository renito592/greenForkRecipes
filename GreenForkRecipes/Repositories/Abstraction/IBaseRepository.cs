using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Repositories.Abstraction
{
    public interface IBaseRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Insert(T t);
        void Update(T t);
        void Delete(int id);

    }
}
