using Parks.Interfaces;
using Parks.Models;

namespace Parks.Repository
{
    public class ParkRepository : RepositoryBase<Park>, IParkRepository
    {
        public ParkRepository(ParksContext repositoryContext)
            : base(repositoryContext)
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