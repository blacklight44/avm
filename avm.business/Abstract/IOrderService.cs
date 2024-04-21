using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.entity;

namespace avm.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
       
    }
}