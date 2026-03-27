/*
order: 60
title: Rephrase Tool
slug: rephrase-tool

Shows how to use DeepL Write API as an AIFunction rephrase tool with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsRephraseTool_CreatesValidTool()
    {
        using var client = CreateTestClient();

        //// Create a rephrasing tool from the DeepL client for use with any IChatClient.
        var tool = client.AsRephraseTool();
        tool.Name.Should().Be("RephraseText");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsRephraseTool_WithStyleAndTone()
    {
        using var client = CreateTestClient();

        //// You can specify writing style and tone for rephrasing.
        var tool = client.AsRephraseTool(
            writingStyle: WritingStyle.Business,
            tone: WritingTone.Confident);
        tool.Name.Should().Be("RephraseText");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task AsRephraseTool_RephrasesText()
    {
        using var client = GetAuthenticatedClient();

        //// Invoke the rephrase tool directly to improve text.
        var tool = client.AsRephraseTool();
        var result = await tool.InvokeAsync(
            new AIFunctionArguments(new Dictionary<string, object?>
            {
                ["text"] = "The thing is very good and I like it a lot because its nice.",
                ["targetLanguage"] = "en-US",
            }));

        result.Should().NotBeNull();
        var text = result?.ToString();
        text.Should().NotBeNullOrWhiteSpace();
    }
}
