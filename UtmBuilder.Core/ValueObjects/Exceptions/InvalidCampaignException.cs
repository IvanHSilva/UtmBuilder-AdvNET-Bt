namespace UtmBuilder.Core.ValueObjects.Exceptions;

public partial class InvalidCampaignException(string message = InvalidCampaignException.ErrorMessage) : Exception(message) {

    private const string ErrorMessage = "Parâmetros inválidos!";

    public static void ThrowIfInvalidCampaign(string url, string message = ErrorMessage) {
        if (string.IsNullOrEmpty(url))
            throw new InvalidCampaignException(message);
    }
}
