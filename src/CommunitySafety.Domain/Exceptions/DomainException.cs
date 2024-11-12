
using CommunitySafety.Domain.Common;

namespace CommunitySafety.Domain.Exceptions;

public sealed class DomainException : Exception
{
    public string ErrorCode { get; private set; }

    public DomainException(Error error) : base(error.Message) 
    {
        ErrorCode = error.Code;
    }

    public override string ToString()
    {
        return $"Error Code: {ErrorCode}, Message: {Message}";
    }
}
