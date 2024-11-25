
using CommunitySafety.Domain.Common;
using CommunitySafety.Domain.Exceptions;

namespace CommunitySafety.Domain.Entities;

public sealed class Category
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public ICollection<Incident> Incidents { get; private set; }

    public Category(string name) 
    {
        Validate(name);
        Name = name;
    }

    public Category(int id, string name)
    {
        Validate(name);
        Id = id;
        Name = name;        
    }

    #region Methods

    public void Update(string name) 
    {
        Validate(name);
        Name = name;
    }

    private void Validate(string name) 
    {
        if (string.IsNullOrEmpty(name))
            throw new DomainException(ErrorCatalog.NullOrEmptyName);

        if (name.Length < 3)
            throw new DomainException(ErrorCatalog.InvalidName);
    }

    #endregion
}
