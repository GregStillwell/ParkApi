using System.Linq.Expressions;
using ParksApi.Interfaces;
using ParksApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ParksApi.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ParksApiContext RepositoryContext { get; set; }

        public RepositoryBase(ParksApiContext repositoryContext)
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