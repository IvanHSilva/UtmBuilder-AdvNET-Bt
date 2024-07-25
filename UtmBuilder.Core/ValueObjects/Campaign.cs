namespace Utm.Core.ValueObjects;

public class Campaign(string source, string medium, string name) 
    : ValueObject
{
    public string Id { get; } = string.Empty;
    public string Source { get; } = source;
    public string Medium { get; } = medium;
    public string Name { get; } = name;
    public string Term { get; } = string.Empty;
    public string Content { get; } = string.Empty;
}
