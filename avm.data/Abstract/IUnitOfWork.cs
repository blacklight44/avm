using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avm.data.Abstract
{
    public interface IUnitOfWork
    {
          ICartRepository Carts {get;}
         ICategoryRepository Categories {get;}
         IOrderRepository Orders {get;}
         IProductRepository Products {get;} 
         void Save();
    }
}