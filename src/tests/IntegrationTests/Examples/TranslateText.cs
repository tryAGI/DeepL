/*
order: 10
title: Translate Text
slug: translate-text

Shows how to translate text between languages using the DeepL API.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TranslateText()
    {
        using var client = GetAuthenticatedClient();

        //// Translate text from English to German using the DeepL API.
        var response = await client.TranslateText.TranslateTextAsync(
            request: new TranslateTextRequest
            {
                Text = ["Hello, world!"],
                TargetLang = TargetLanguage.De,
            });

        response.Translations.Should().NotBeEmpty();
        response.Translations[0].Text.Should().NotBeNullOrEmpty();
        response.Translations[0].DetectedSourceLanguage.Should().NotBeNull();
    }
}
