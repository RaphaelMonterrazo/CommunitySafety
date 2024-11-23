
using AutoMapper;
using CommunitySafety.Application.DTOs;
using CommunitySafety.Application.Interfaces;
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;

namespace CommunitySafety.Application.Services;

public class LocationService : ILocationService
{
    private readonly ILocationRepository _locationRepository;
    private readonly IMapper _mapper;

    public LocationService(ILocationRepository locationRepository, IMapper mapper)
    {
        _locationRepository = locationRepository;
        _mapper = mapper;
    }

    public async Task<LocationDTO> AddAsync(LocationDTO locationDTO)
    {
        var locationEntity = _mapper.Map<Location>(locationDTO);

        await _locationRepository.CreateAsync(locationEntity);

        return _mapper.Map<LocationDTO>(locationEntity);
    }

    public async Task<LocationDTO?> GetLocationByLatitudeAndLongitude(LocationDTO location)
    {
        var locationEntity = _mapper.Map<Location>(location);

        var result = await _locationRepository.GetLocationByLatitudeAndLongitude(locationEntity);

        return _mapper.Map<LocationDTO>(result);
    }
}
