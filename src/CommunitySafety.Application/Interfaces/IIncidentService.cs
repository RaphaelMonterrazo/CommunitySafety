
using CommunitySafety.Application.DTOs;

namespace CommunitySafety.Application.Interfaces;

public interface IIncidentService
{
    Task<IncidentDTO> AddAsync(IncidentDTO incidentDTO);
    Task<IEnumerable<IncidentDTO>> GetAllAsync();
}
