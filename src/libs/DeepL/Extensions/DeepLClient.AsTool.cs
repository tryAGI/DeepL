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
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsTranslateTool(
        this DeepLClient client,
        TargetLanguage defaultTargetLanguage = TargetLanguage.En)
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
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsRephraseTool(this DeepLClient client)
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
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRephraseResponse(response);
            },
            name: "RephraseText",
            description: "Improves and rephrases text using DeepL Write API. Enhances clarity, tone, and style. Supports English, German, French, Italian, and Portuguese (including regional variants like 'en-US', 'en-GB', 'pt-BR').");
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
