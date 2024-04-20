using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avm.entity;

namespace avm.data.Abstract
{
     public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}