﻿
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;
using CommunitySafety.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CommunitySafety.Infrastructure.Repositories;

public class IncidentRepository : IIncidentRepository
{
    private readonly ApplicationDbContext _context;
    public IncidentRepository(ApplicationDbContext context)
    {
        _context = context;        
    }
    public async Task<Incident> CreateAsync(Incident incident)
    {
        _context.Incidents.Add(incident);
        await _context.SaveChangesAsync();
        return incident;
    }

    public async Task<IEnumerable<Incident>> GetIncidentsAsync()
    {
        return await _context
            .Incidents
            .Include(i => i.Location)
            .Include(i => i.Category)
            .ToListAsync();
    }
}
