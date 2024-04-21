using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.entity;

namespace avm.business.Abstract
{
    public interface ICategoryService
    {
         List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);
        void Delete(Category entity);
    }
}