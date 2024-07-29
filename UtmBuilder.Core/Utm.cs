using Utm.Core.ValueObjects;
using UtmBuilder.Core.Extensions;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaign)
{
    public Url Url { get; } = url;
    public Campaign Campaign { get; } = campaign;

    public static implicit operator string(Utm utm) => utm.ToString();

    public override string ToString() {
        List<string> segments = [];
        segments.AddIfNotNull("utm_source", Campaign.Source);
        segments.AddIfNotNull("utm_medium", Campaign.Medium);
        segments.AddIfNotNull("utm_campaign", Campaign.Name);
        segments.AddIfNotNull("utm_id", Campaign.Id);
        segments.AddIfNotNull("utm_term", Campaign.Term);
        segments.AddIfNotNull("utm_content", Campaign.Content);
        return $"{Url.Address}?{string.Join("&", segments)}";
    }
}
