
using CommunitySafety.Domain.Entities;

namespace CommunitySafety.Domain.Interfaces
{
    public interface ILocationRepository
    {
        Task<Location> CreateAsync(Location location);
    }
}
