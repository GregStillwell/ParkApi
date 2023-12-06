using ParksApi.Interfaces;
using ParksApi.Models;

namespace ParksApi.Repository
{
    public class ParkApiRepository : RepositoryBase<Park>, IParkRepository
    {
        public ParkApiRepository(ParksApiContext repositoryContext) : base(repositoryContext)
        {
        }

        public PagedList<Park> GetParks(PagedParameters parkParameters)
        {
            return PagedList<Park>.ToPagedList(FindAll(),
                parkParameters.PageNumber,
                parkParameters.PageSize);
        }

        public Park GetParkById(Guid parkId)
        {
            return FindByCondition(park => park.ParkId.Equals(parkId))
                .DefaultIfEmpty(new Park())
                .FirstOrDefault();
        }

    }
}