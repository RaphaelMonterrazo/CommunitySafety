
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;
using CommunitySafety.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

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

    public async Task<Location?> GetLocationByLatitudeAndLongitude(Location location)
    {
        return await _context.Locations
                                .Where(l => l.Latitude == location.Latitude && l.Longitude == location.Longitude)
                                .FirstOrDefaultAsync();
    }
}
