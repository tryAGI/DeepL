/*
order: 30
title: Get Usage
slug: get-usage

Shows how to retrieve account usage information.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetUsage()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve your DeepL account usage (character count and limits).
        var response = await client.GetUsageAsync();

        response.CharacterCount.Should().BeGreaterOrEqualTo(0);
    }
}
