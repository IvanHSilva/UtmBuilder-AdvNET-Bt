namespace Utm.Core.ValueObjects;

public class Url(string address) : ValueObject
{
    public string Address { get; } = address;
}
