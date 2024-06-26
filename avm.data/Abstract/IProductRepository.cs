using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.entity;
namespace avm.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        Product GetProductDetails(string url);
    }
}