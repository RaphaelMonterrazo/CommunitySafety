
namespace CommunitySafety.Domain.Common;

public static class ErrorCatalog
{
    public static readonly Error NullOrEmptyName = new ("E001", "Invalid Name.  Null or Empty name is not allowed");
    public static readonly Error InvalidName = new ("E002", "Invalid Name.  Name shorter than 3 characters is not allowed");
    public static readonly Error NullOrEmptyDescription = new("E003", "Invalid Description.  Null or Empty description is not allowed");
    public static readonly Error InvalidDescription = new("E004", "Invalid Description.  Description shorter than 3 characters is not allowed");
}
