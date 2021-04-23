using AutoMapper;
using GreenForkRecipes.Models;
using GreenForkRecipes.Repositories.Abstraction;
using GreenForkRecipes.ViewModels;
using Microsoft.CodeAnalysis.Differencing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.ModelServices.Abstractions
{
    public class BaseService<TModel, TDetailsVM, TEditVM> : IBaseService<TModel, TDetailsVM, TEditVM>
        where TModel : BaseModel
        where TDetailsVM : BaseVM
        where TEditVM : BaseVM
    {

        protected readonly IBaseRepository<TModel> repository;
        protected readonly IMapper mapper;

        public BaseService(IBaseRepository<TModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public virtual void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<TDetailsVM> GetAll()
        {
            return repository.GetAll()
                .Select(model => mapper.Map<TModel, TDetailsVM>(model))
                .ToList();
        }

        public TEditVM GetById(int id)
        {
            TModel model =  repository.GetById(id);
           return mapper.Map<TModel, TEditVM>(model);          
        }

        public TDetailsVM GetDetails(int id)
        {
            TModel model = repository.GetById(id);
            return mapper.Map<TModel, TDetailsVM>(model);
        }

        public void Insert(TEditVM t)
        {
           repository.Insert(mapper.Map<TEditVM, TModel>(t));
        }

        public void Update(TEditVM t)
        {
            repository.Update(mapper.Map<TEditVM, TModel>(t));
        }
    }
}
