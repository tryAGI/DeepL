/*
order: 70
title: Document Translation Tool
slug: translate-document-tool

Shows how to use DeepL document translation as an AIFunction tool with any IChatClient.
*/

using System.Text;
using Microsoft.Extensions.AI;

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTranslateDocumentTool_CreatesValidTool()
    {
        using var client = CreateTestClient();

        //// Create a document translation tool from the DeepL client for use with any IChatClient.
        var tool = client.AsTranslateDocumentTool();
        tool.Name.Should().Be("TranslateDocument");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsTranslateDocumentTool_WithOptions()
    {
        using var client = CreateTestClient();

        //// You can specify default target language, formality, and polling interval.
        var tool = client.AsTranslateDocumentTool(
            defaultTargetLanguage: TargetLanguage.Fr,
            formality: Formality.More,
            pollIntervalMs: 2000);
        tool.Name.Should().Be("TranslateDocument");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task AsTranslateDocumentTool_TranslatesDocument()
    {
        using var client = GetAuthenticatedClient();

        //// Invoke the document translation tool with a base64-encoded text file.
        var tool = client.AsTranslateDocumentTool(defaultTargetLanguage: TargetLanguage.De);
        var content = Convert.ToBase64String(Encoding.UTF8.GetBytes("Hello, world!"));

        var result = await tool.InvokeAsync(
            new AIFunctionArguments(new Dictionary<string, object?>
            {
                ["base64Content"] = content,
                ["filename"] = "hello.txt",
                ["targetLanguage"] = "DE",
            }));

        result.Should().NotBeNull();
        var text = result?.ToString();
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("translated successfully");
    }
}
