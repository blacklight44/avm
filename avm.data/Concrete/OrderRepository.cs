using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.data.Abstract;
using avm.entity;
namespace avm.data.Concrete
{
    public class OrderRepository: GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ShopContext context): base(context)
        {
            
        }
          
        private ShopContext ShopContext
        {
            get {return context as ShopContext; }
        }
    }
}