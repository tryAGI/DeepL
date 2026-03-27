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
}
