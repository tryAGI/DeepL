/*
order: 20
title: Rephrase Text
slug: rephrase-text

Shows how to use the DeepL Write API to rephrase text.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task RephraseText()
    {
        using var client = GetAuthenticatedClient();

        //// Use the DeepL Write API to rephrase text for improved style and clarity.
        var response = await client.RephraseText.RephraseTextAsync(
            request: new RephraseTextRequest
            {
                Text = ["The weather is very nice today and I think we should go outside."],
                TargetLang = TargetLanguageWrite.EnUs,
            });

        response.Improvements.Should().NotBeEmpty();
        response.Improvements[0].Text.Should().NotBeNullOrEmpty();
    }
}
