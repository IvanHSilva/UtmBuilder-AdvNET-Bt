using Utm.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaign)
{
    public Url Url { get; } = url;
    public Campaign Campaign { get; } = campaign;
}
