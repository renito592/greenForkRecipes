using GreenForkRecipes.Models;
using GreenForkRecipes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.ModelServices.Abstractions
{
    public interface IBaseService<TModel,TDetailsVM,TEditVM>
        where TModel : BaseModel
        where TDetailsVM : BaseVM
        where TEditVM : BaseVM
    {
        TEditVM GetById(int id);
        TDetailsVM GetDetails(int id);
        List<TDetailsVM> GetAll();
        void Insert(TEditVM t);
        void Update(TEditVM t);
        void Delete(int id);
    }
}
