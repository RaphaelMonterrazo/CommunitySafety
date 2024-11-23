
using AutoMapper;
using CommunitySafety.Application.DTOs;
using CommunitySafety.Application.Interfaces;
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;

namespace CommunitySafety.Application.Services;

public class IncidentService : IIncidentService
{
    private readonly IIncidentRepository _incidentRepository;
    private readonly IMapper _mapper;
    public IncidentService(IIncidentRepository incidentRepository, IMapper mapper)
    {
        _incidentRepository = incidentRepository;
        _mapper = mapper;
    }

    public async Task<IncidentDTO> AddAsync(IncidentDTO incidentDTO)
    {
        var incidentEntity = _mapper.Map<Incident>(incidentDTO);

        var result = await _incidentRepository.CreateAsync(incidentEntity);

        return _mapper.Map<IncidentDTO>(result);
    }

}
