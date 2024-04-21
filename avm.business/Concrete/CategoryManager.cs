using System.Collections.Generic;
using avm.business.Abstract;
using avm.data.Abstract;
using avm.entity;

namespace avm.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
         private readonly IUnitOfWork _unitofwork;
        public CategoryManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

    

        public void Create(Category entity)
        {
            _unitofwork.Categories.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Category entity)
        {
            _unitofwork.Categories.Delete(entity);
            _unitofwork.Save();
        }



        public List<Category> GetAll()
        {
            return _unitofwork.Categories.GetAll();
        }

    

        public void Update(Category entity)
        {
            _unitofwork.Categories.Update(entity);
            _unitofwork.Save();
        }

    
    }
}