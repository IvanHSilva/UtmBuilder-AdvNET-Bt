using UtmBuilder.Core.ValueObjects.Exceptions;

namespace Utm.Core.ValueObjects;

public class Campaign : ValueObject
{
    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string Id { get; } = string.Empty;
    public string Term { get; } = string.Empty;
    public string Content { get; } = string.Empty;

    public Campaign(string source, string medium, string name, 
        string id = "", string term = "", string content = "") {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;

        InvalidCampaignException.ThrowIfInvalidCampaign(source, "Fonte inválida!");
        InvalidCampaignException.ThrowIfInvalidCampaign(medium, "Mídia inválida!");
        InvalidCampaignException.ThrowIfInvalidCampaign(name, "Nome inválido!");
    }
}
