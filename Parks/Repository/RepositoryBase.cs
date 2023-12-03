using System.Linq.Expressions;
using Parks.Interfaces;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

namespace Parks.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ParksContext RepositoryContext { get; set; }

        public RepositoryBase(ParksContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>()
            .AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>()
            .Where(expression)
            .AsNoTracking();
        }
    }
}