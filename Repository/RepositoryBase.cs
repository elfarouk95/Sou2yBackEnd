using System;
using System.Linq;
using System.Linq.Expressions;
using Contracts;
using Entitis.Data;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        RepositoryContext context;

        public RepositoryBase(RepositoryContext _context)
        {
            this.context = _context;
        }


        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindALl(bool trackChanges)
        {
            return  context.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return context.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}
