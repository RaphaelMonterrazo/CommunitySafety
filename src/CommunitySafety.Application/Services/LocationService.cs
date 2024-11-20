
using CommunitySafety.Application.DTOs;
using CommunitySafety.Application.Interfaces;

namespace CommunitySafety.Application.Services;

public class LocationService : ILocationService
{
    public Task<IEnumerable<LocationDTO>> GetLocationsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<LocationDTO> GetLocationByIdAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(LocationDTO locationDTO)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(LocationDTO locationDTO)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(LocationDTO locationDTO)
    {
        throw new NotImplementedException();
    }    
}
