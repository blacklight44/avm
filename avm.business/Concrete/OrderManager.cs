using System.Collections.Generic;
using avm.business.Abstract;
using avm.data.Abstract;
using avm.entity;

namespace avm.business.Concrete
{
    public class OrderManager : IOrderService
    {
         private readonly IUnitOfWork _unitofwork;
        public OrderManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public void Create(Order entity)
        {
            _unitofwork.Orders.Create(entity);
            _unitofwork.Save();
        }

      
    }
}