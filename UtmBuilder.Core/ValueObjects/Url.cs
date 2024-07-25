using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace Utm.Core.ValueObjects;

public class Url : ValueObject
{

    // Address of URL (Site link)
    public string Address { get; }

    public Url(string address) {
        Address = address;
        InvalidUrlException.ThrowIfInvalidUrl(address);
    }
}
