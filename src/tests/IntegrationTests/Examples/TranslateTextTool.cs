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
    public void AsTranslateTool_WithDefaultLanguage()
    {
        using var client = CreateTestClient();

        //// You can specify a default target language for translations.
        var tool = client.AsTranslateTool(defaultTargetLanguage: TargetLanguage.De);
        tool.Name.Should().Be("TranslateText");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
