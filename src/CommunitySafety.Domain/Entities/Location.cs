
namespace CommunitySafety.Domain.Entities;

public sealed class Location
{
    public int Id { get; private set; }
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }
    public ICollection<Incident> Incidents { get; private set; }

    public Location(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public Location(int id, double latitude, double longitude)
    {
        Id = id;
        Latitude = latitude;
        Longitude = longitude;
    }

    #region Methods

    public void Update(double latitude, double longitude) 
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    #endregion
}
