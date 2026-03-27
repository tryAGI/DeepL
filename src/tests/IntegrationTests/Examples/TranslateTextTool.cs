/*
order: 50
title: Translate Tool
slug: translate-tool

Shows how to use DeepL as an AIFunction translate tool with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTranslateTool_CreatesValidTool()
    {
        using var client = CreateTestClient();

        //// Create a translation tool from the DeepL client for use with any IChatClient.
        var tool = client.AsTranslateTool();
        tool.Name.Should().Be("TranslateText");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsTranslateTool_WithDefaultLanguageAndFormality()
    {
        using var client = CreateTestClient();

        //// You can specify a default target language and formality level.
        var tool = client.AsTranslateTool(
            defaultTargetLanguage: TargetLanguage.De,
            formality: Formality.More);
        tool.Name.Should().Be("TranslateText");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task AsTranslateTool_TranslatesText()
    {
        using var client = GetAuthenticatedClient();

        //// Invoke the translation tool directly to translate text.
        var tool = client.AsTranslateTool(defaultTargetLanguage: TargetLanguage.De);
        var result = await tool.InvokeAsync(
            new AIFunctionArguments(new Dictionary<string, object?>
            {
                ["text"] = "Hello, world!",
                ["targetLanguage"] = "DE",
            }));

        result.Should().NotBeNull();
        var text = result?.ToString();
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("Hallo");
    }
}
