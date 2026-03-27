/*
order: 40
title: List Languages
slug: list-languages

Shows how to list supported languages.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListLanguages()
    {
        using var client = GetAuthenticatedClient();

        //// List all supported source and target languages.
        var languages = await client.MetaInformation.GetLanguagesAsync();

        languages.Should().NotBeEmpty();
        languages[0].Language.Should().NotBeNullOrEmpty();
        languages[0].Name.Should().NotBeNullOrEmpty();
    }
}
