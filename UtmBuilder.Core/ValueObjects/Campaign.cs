using UtmBuilder.Core.ValueObjects.Exceptions;

namespace Utm.Core.ValueObjects;

public class Campaign : ValueObject
{
    public string Id { get; } = string.Empty;
    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string Term { get; } = string.Empty;
    public string Content { get; } = string.Empty;

    public Campaign(string source, string medium, string name) {
        Source = source;
        Medium = medium;
        Name = name;

        InvalidCampaignException.ThrowIfInvalidCampaign(source, "Fonte inválida!");
        InvalidCampaignException.ThrowIfInvalidCampaign(medium, "Mídia inválida!");
        InvalidCampaignException.ThrowIfInvalidCampaign(name, "Nome inválido!");
    }
}
