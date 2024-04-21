using System.Collections.Generic;
using avm.business.Abstract;
using avm.data.Abstract;
using avm.data.Concrete;
using avm.entity;

namespace avm.business.Concrete
{
    public class ProductManager : IProductService
    {

         private readonly IUnitOfWork _unitofwork;
        public ProductManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public bool Create(Product entity)
        {
          
                 
                _unitofwork.Products.Create(entity);
                _unitofwork.Save();
                return true;
            
        }

        public void Delete(Product entity)
        {
            // iş kuralları
            _unitofwork.Products.Delete(entity);
            _unitofwork.Save();
        }

        public List<Product> GetAll()
        {            
            return _unitofwork.Products.GetAll();
        }

               public void Update(Product entity)
        {            
            _unitofwork.Products.Update(entity);
            _unitofwork.Save();
        }

    
      
    }
}