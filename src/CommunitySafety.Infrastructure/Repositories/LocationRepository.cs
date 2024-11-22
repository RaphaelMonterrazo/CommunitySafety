
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;
using CommunitySafety.Infrastructure.Context;

namespace CommunitySafety.Infrastructure.Repositories;

public class LocationRepository : ILocationRepository
{
    private readonly ApplicationDbContext _context;

    public LocationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Location> CreateAsync(Location location)
    {
        _context.Locations.Add(location);
        await _context.SaveChangesAsync();
        return location;
    }
}
