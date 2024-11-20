
using CommunitySafety.Application.DTOs;

namespace CommunitySafety.Application.Interfaces;

public interface IIncidentService
{
    Task<IEnumerable<IncidentDTO>> GetIncidentsAsync();
    Task<IncidentDTO> GetIncidentByIdAsync(int id);
    Task AddAsync(IncidentDTO incidentDTO);
    Task UpdateAsync(IncidentDTO incidentDTO);
    Task RemoveAsync(IncidentDTO incidentDTO);
}
