/*
order: 90
title: Free API Endpoint
slug: free-api-endpoint

Shows how to use the DeepL Free API endpoint instead of the Pro endpoint.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void FreeApiEndpoint()
    {
        //// DeepL offers two API tiers with different base URLs:
        //// - Pro:  https://api.deepl.com (default)
        //// - Free: https://api-free.deepl.com
        ////
        //// To use the Free API, pass the base URL to the constructor.
        using var freeClient = new DeepLClient(
            apiKey: "test-key",
            baseUri: new System.Uri("https://api-free.deepl.com"));

        freeClient.Should().NotBeNull();

        //// The Pro API is the default — no base URL needed.
        using var proClient = new DeepLClient(apiKey: "test-key");

        proClient.Should().NotBeNull();
    }
}
