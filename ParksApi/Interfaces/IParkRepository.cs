using ParksApi.Models;

namespace ParksApi.Interfaces
{
  public interface IParkRepository : IRepositoryBase<Park>
  {
    PagedList<Park> GetParks(PagedParameters parkParameters);
    Park GetParkById(Guid parkId);
  }
}