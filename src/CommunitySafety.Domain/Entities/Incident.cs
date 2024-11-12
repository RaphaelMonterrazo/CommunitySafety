
namespace CommunitySafety.Domain.Entities;

public sealed class Incident : EntityBase
{
    public string Description { get; private set; }
    public DateTime ReportedAt { get; private set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; }
    public long LocationId { get; set; }
    public Location Location { get; set; }

    public Incident(string description) 
    {
        Description = description;
        ReportedAt = DateTime.UtcNow;
    }

    #region Methods

    public void Update(string description, long categoryId, long locationId) 
    {
        Description = description;
        CategoryId = categoryId;
        LocationId = locationId;
    }

    #endregion
}
