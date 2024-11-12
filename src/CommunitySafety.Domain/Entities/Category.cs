
namespace CommunitySafety.Domain.Entities;

public sealed class Category : EntityBase
{
    public string Name { get; private set; }
    public ICollection<Incident> Incidents { get; private set; }

    public Category(string name) 
    {
        Name = name;
    }

    #region Methods

    public void Update(string name) 
    {
        Name = name;
    }

    #endregion
}
