using System.Text.RegularExpressions;

namespace Utm.Core.ValueObjects;

public class Url : ValueObject
{
    private const string UrlRegexPattern =
        @"^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$)]";

    public Url(string address) {
        Address = address;
        if (Regex.IsMatch(Address, UrlRegexPattern))
            throw new ArgumentException("Erro na Url");
    }

    // Address of URL (Site link)
    public string Address { get; }
}
