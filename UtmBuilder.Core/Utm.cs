using Utm.Core.ValueObjects;
using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaign)
{
    public Url Url { get; } = url;
    public Campaign Campaign { get; } = campaign;

    public static implicit operator string(Utm utm) => utm.ToString();
    
    public static implicit operator Utm(string link) {
        if (string.IsNullOrEmpty(link))
            throw new InvalidUrlException();

        Url url = new(link);
        string[] division = url.Address.Split("?");
        if (division.Length == 1)
            throw new InvalidUrlException();

        string[] segments = division[1].Split("&");
        string source = segments.Where(u => u.StartsWith("utm_source")).FirstOrDefault("").Split("=")[1];
        string medium = segments.Where(u => u.StartsWith("utm_medium")).FirstOrDefault("").Split("=")[1];
        string name = segments.Where(u => u.StartsWith("utm_campaign")).FirstOrDefault("").Split("=")[1];
        string id = segments.Where(u => u.StartsWith("utm_id")).FirstOrDefault("").Split("=")[1];
        string term = segments.Where(u => u.StartsWith("utm_term")).FirstOrDefault("").Split("=")[1];
        string content = segments.Where(u => u.StartsWith("utm_content")).FirstOrDefault("").Split("=")[1];

        Utm utm = new(new Url(division[0]),
            new Campaign(source, medium, name, id, term, content));

        return utm;
    }


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
