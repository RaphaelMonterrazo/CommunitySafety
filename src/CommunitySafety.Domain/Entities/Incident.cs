
using CommunitySafety.Domain.Common;
using CommunitySafety.Domain.Exceptions;

namespace CommunitySafety.Domain.Entities;

public sealed class Incident
{
    public int Id { get; private set; }
    public string Description { get; private set; }
    public DateTime ReportedAt { get; private set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }

    public Incident(string description) 
    {
        Validate(description);
        Description = description;
        ReportedAt = DateTime.UtcNow;
    }

    #region Methods

    public void Update(string description, int categoryId, int locationId) 
    {
        Description = description;
        CategoryId = categoryId;
        LocationId = locationId;
    }

    private void Validate(string Description)
    {
        if (string.IsNullOrEmpty(Description))
            throw new DomainException(ErrorCatalog.NullOrEmptyDescription);

        if (Description.Length < 3)
            throw new DomainException(ErrorCatalog.InvalidDescription);
    }

    #endregion
}
