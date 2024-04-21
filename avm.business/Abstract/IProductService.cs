using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.entity;

namespace avm.business.Abstract
{
    public interface IProductService
    {
          List<Product> GetAll();
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}