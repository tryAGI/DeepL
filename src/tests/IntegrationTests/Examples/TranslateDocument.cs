/*
order: 50
title: Translate Document
slug: translate-document

Shows how to translate a document using the upload-poll-download workflow.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TranslateDocument()
    {
        using var client = GetAuthenticatedClient();

        //// DeepL's document translation follows a three-step workflow:
        //// 1. Upload the document and specify the target language
        //// 2. Poll for translation status until complete
        //// 3. Download the translated document

        //// Step 1: Upload a text file for translation.
        var content = "Hello, world! This is a test document for translation."u8.ToArray();
        var uploadResponse = await client.TranslateDocuments.TranslateDocumentAsync(
            targetLang: TargetLanguage.De,
            file: content,
            filename: "test.txt");

        uploadResponse.DocumentId.Should().NotBeNullOrEmpty();
        uploadResponse.DocumentKey.Should().NotBeNullOrEmpty();

        //// Step 2: Poll until the document translation is complete.
        GetDocumentStatusResponse status;
        do
        {
            await Task.Delay(1000);
            status = await client.TranslateDocuments.GetDocumentStatusAsync(
                documentId: uploadResponse.DocumentId!,
                documentKey1: uploadResponse.DocumentKey!);
        }
        while (status.Status is GetDocumentStatusResponseStatus.Queued
            or GetDocumentStatusResponseStatus.Translating);

        status.Status.Should().Be(GetDocumentStatusResponseStatus.Done);

        //// Step 3: Download the translated document (one-time download).
        var translatedBytes = await client.TranslateDocuments.DownloadDocumentAsync(
            documentId: uploadResponse.DocumentId!,
            documentKey1: uploadResponse.DocumentKey!);

        translatedBytes.Should().NotBeEmpty();
        var translatedText = System.Text.Encoding.UTF8.GetString(translatedBytes);
        translatedText.Should().NotBeNullOrEmpty();
    }
}
