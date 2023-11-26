using System.Linq.Expressions;

namespace Parks.Interfaces
{
  public interface IRepositoryBase<T>
  {
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
  }
}