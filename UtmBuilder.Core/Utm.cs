using Utm.Core.ValueObjects;
using UtmBuilder.Core.Extensions;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaign)
{
    public Url Url { get; } = url;
    public Campaign Campaign { get; } = campaign;

    public override string ToString() {
        List<string> segments = [];
        segments.AddIfNotNull();
        return $"{Url.Address}?{string.Join("&", segments)}";
    }
}
