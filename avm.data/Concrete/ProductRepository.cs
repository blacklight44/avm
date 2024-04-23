using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using avm.data.Abstract;
using avm.entity;
namespace avm.data.Concrete
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
         public ProductRepository(ShopContext context): base(context)
        {
            
        }

        private ShopContext ShopContext
        {
            get {return context as ShopContext; }
        }

         public Product GetProductDetails(string url)
        {
                return ShopContext.Products
                                .Where(i=>i.Url==url)
                                .Include(i=>i.ProductCategories)
                                .ThenInclude(i=>i.Category)
                                .FirstOrDefault();

        }
    }
}