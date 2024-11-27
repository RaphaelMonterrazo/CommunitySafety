
namespace CommunitySafety.Domain.Entities;

public sealed class Location
{
    public int Id { get; private set; }
    public string Latitude { get; private set; }
    public string Longitude { get; private set; }
    public ICollection<Incident> Incidents { get; private set; }

    public Location(string latitude, string longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public Location(int id, string latitude, string longitude)
    {
        Id = id;
        Latitude = latitude;
        Longitude = longitude;
    }

    #region Methods

    public void Update(string latitude, string longitude) 
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    #endregion
}
