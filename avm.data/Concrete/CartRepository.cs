using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.data.Abstract;
using avm.entity;

namespace avm.data.Concrete
{
    public class CartRepository: GenericRepository<Cart>, ICartRepository
    {
         public CartRepository(ShopContext context): base(context)
        {
            
        }

        private ShopContext ShopContext
        {
            get {return context as ShopContext; }
        }
    }
}