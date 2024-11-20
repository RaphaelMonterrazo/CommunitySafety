
using CommunitySafety.Application.DTOs;
using CommunitySafety.Application.Interfaces;

namespace CommunitySafety.Application.Services;

public class IncidentService : IIncidentService
{
    public Task<IEnumerable<IncidentDTO>> GetIncidentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IncidentDTO> GetIncidentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(IncidentDTO incidentDTO)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(IncidentDTO incidentDTO)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(IncidentDTO incidentDTO)
    {
        throw new NotImplementedException();
    }    
}
