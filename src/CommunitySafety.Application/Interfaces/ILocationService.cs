using CommunitySafety.Application.DTOs;

namespace CommunitySafety.Application.Interfaces;

public interface ILocationService
{
    Task<IEnumerable<LocationDTO>> GetLocationsAsync();
    Task<LocationDTO> GetLocationByIdAsync();
    Task AddAsync(LocationDTO locationDTO);
    Task UpdateAsync(LocationDTO locationDTO);
    Task RemoveAsync(LocationDTO locationDTO);
}
