namespace BlandAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BlandAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BLANDAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BLANDAI_API_KEY environment variable is not found.");

        var client = new BlandAIClient(apiKey);
        
        return client;
    }
}
