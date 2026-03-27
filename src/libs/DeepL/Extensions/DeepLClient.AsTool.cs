#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text;
using Microsoft.Extensions.AI;

namespace DeepL;

/// <summary>
/// Extensions for using DeepLClient as MEAI tools with any IChatClient.
/// </summary>
public static class DeepLToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps DeepL text translation,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The DeepL client to use for translations.</param>
    /// <param name="defaultTargetLanguage">Default target language when not specified by the model (default: EN).</param>
    /// <param name="formality">Formality level for translations (default: null, uses DeepL default).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsTranslateTool(
        this DeepLClient client,
        TargetLanguage defaultTargetLanguage = TargetLanguage.En,
        Formality? formality = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string? targetLanguage, string? sourceLanguage, CancellationToken cancellationToken) =>
            {
                var targetLang = targetLanguage is { Length: > 0 }
                    ? TargetLanguageExtensions.ToEnum(targetLanguage) ?? defaultTargetLanguage
                    : defaultTargetLanguage;

                var sourceLang = sourceLanguage is { Length: > 0 }
                    ? SourceLanguageExtensions.ToEnum(sourceLanguage)
                    : null;

                var response = await client.TranslateText.TranslateTextAsync(
                    text: [text],
                    targetLang: targetLang,
                    sourceLang: sourceLang,
                    formality: formality,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTranslateResponse(response);
            },
            name: "TranslateText",
            description: "Translates text from one language to another using DeepL. Supports 30+ languages with automatic source language detection. Pass language codes like 'DE', 'FR', 'ES', 'EN-US', 'PT-BR', etc.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps DeepL text rephrasing (Write API),
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The DeepL client to use for rephrasing.</param>
    /// <param name="writingStyle">Writing style preference (default: null, uses DeepL default).</param>
    /// <param name="tone">Tone preference (default: null, uses DeepL default).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsRephraseTool(
        this DeepLClient client,
        WritingStyle? writingStyle = null,
        WritingTone? tone = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string? targetLanguage, CancellationToken cancellationToken) =>
            {
                var targetLang = targetLanguage is { Length: > 0 }
                    ? TargetLanguageWriteExtensions.ToEnum(targetLanguage)
                    : null;

                var response = await client.RephraseText.RephraseTextAsync(
                    text: [text],
                    targetLang: targetLang,
                    writingStyle: writingStyle,
                    tone: tone,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRephraseResponse(response);
            },
            name: "RephraseText",
            description: "Improves and rephrases text using DeepL Write API. Enhances clarity, tone, and style. Supports English, German, French, Italian, and Portuguese (including regional variants like 'en-US', 'en-GB', 'pt-BR').");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps DeepL document translation,
    /// suitable for use as a tool with any IChatClient.
    /// Handles the full 3-step workflow: upload, poll for completion, and download.
    /// </summary>
    /// <param name="client">The DeepL client to use for document translation.</param>
    /// <param name="defaultTargetLanguage">Default target language when not specified by the model (default: EN).</param>
    /// <param name="formality">Formality level for translations (default: null, uses DeepL default).</param>
    /// <param name="pollIntervalMs">Polling interval in milliseconds when waiting for translation (default: 1000).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsTranslateDocumentTool(
        this DeepLClient client,
        TargetLanguage defaultTargetLanguage = TargetLanguage.En,
        Formality? formality = null,
        int pollIntervalMs = 1000)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string base64Content, string filename, string? targetLanguage, CancellationToken cancellationToken) =>
            {
                var targetLang = targetLanguage is { Length: > 0 }
                    ? TargetLanguageExtensions.ToEnum(targetLanguage) ?? defaultTargetLanguage
                    : defaultTargetLanguage;

                var fileBytes = Convert.FromBase64String(base64Content);

                // Step 1: Upload
                var uploadResponse = await client.TranslateDocuments.TranslateDocumentAsync(
                    targetLang: targetLang,
                    file: fileBytes,
                    filename: filename,
                    formality: formality,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var documentId = uploadResponse.DocumentId
                    ?? throw new InvalidOperationException("No document ID returned from upload.");
                var documentKey = uploadResponse.DocumentKey
                    ?? throw new InvalidOperationException("No document key returned from upload.");

                // Step 2: Poll until done
                while (true)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var status = await client.TranslateDocuments.GetDocumentStatusAsync(
                        documentId: documentId,
                        documentKey1: documentKey,
                        cancellationToken: cancellationToken).ConfigureAwait(false);

                    if (status.Status == GetDocumentStatusResponseStatus.Done)
                    {
                        break;
                    }

                    if (status.Status == GetDocumentStatusResponseStatus.Error)
                    {
                        return $"Document translation failed: {status.ErrorMessage ?? "Unknown error"}";
                    }

                    await Task.Delay(pollIntervalMs, cancellationToken).ConfigureAwait(false);
                }

                // Step 3: Download
                var resultBytes = await client.TranslateDocuments.DownloadDocumentAsync(
                    documentId: documentId,
                    documentKey1: documentKey,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Document translated successfully. Result ({resultBytes.Length} bytes, base64): {Convert.ToBase64String(resultBytes)}";
            },
            name: "TranslateDocument",
            description: "Translates a document file using DeepL. Accepts base64-encoded file content and a filename (e.g., 'report.docx', 'readme.txt'). Supports DOCX, PPTX, XLSX, PDF, HTM/HTML, TXT, XLF/XLIFF, SRT, SBV, VTT, FB2. Returns the translated document as base64. Pass language codes like 'DE', 'FR', 'ES', 'EN-US', etc.");
    }

    private static string FormatTranslateResponse(TranslateTextResponse response)
    {
        if (response.Translations is not { Count: > 0 })
        {
            return "No translation returned.";
        }

        var translation = response.Translations[0];
        var parts = new List<string>();

        if (translation.Text is { Length: > 0 })
        {
            parts.Add(translation.Text);
        }

        if (translation.DetectedSourceLanguage is { } detected)
        {
            parts.Add($"(Detected source language: {detected.ToValueString()})");
        }

        return string.Join("\n", parts);
    }

    private static string FormatRephraseResponse(RephraseTextResponse response)
    {
        if (response.Improvements is not { Count: > 0 })
        {
            return "No improvement returned.";
        }

        return response.Improvements[0].Text ?? "No improvement returned.";
    }
}
