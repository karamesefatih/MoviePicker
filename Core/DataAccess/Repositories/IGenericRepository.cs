using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    // I just defined the DML and DDL methods we need customly as interface in Generic Repository
    // I defined every method generic so i can use them with every entity model
    public interface IGenericRepository<T> where T : class,IEntity, new() 
    {

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
