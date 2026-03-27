namespace DeepL.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DeepLClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPL_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DEEPL_API_KEY environment variable is not found.");

        var client = new DeepLClient(apiKey);
        
        return client;
    }

    private static DeepLClient CreateTestClient() => new(apiKey: "test-key");
}
