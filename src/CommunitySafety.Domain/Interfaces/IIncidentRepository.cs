
using CommunitySafety.Domain.Entities;

namespace CommunitySafety.Domain.Interfaces;

public interface IIncidentRepository
{
    Task<IEnumerable<Incident>> GetIncidentsAsync();
    Task<Incident> CreateAsync(Incident incident);
}
