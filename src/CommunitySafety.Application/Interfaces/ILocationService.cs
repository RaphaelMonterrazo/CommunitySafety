using CommunitySafety.Application.DTOs;

namespace CommunitySafety.Application.Interfaces;

public interface ILocationService
{
    Task<LocationDTO> AddAsync(LocationDTO locationDTO);
    Task<LocationDTO?> GetLocationByLatitudeAndLongitude(LocationDTO locationDTO);
}
