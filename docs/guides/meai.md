# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The DeepL SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models translation, text improvement, and document translation capabilities.

## Installation

```bash
dotnet add package DeepL
```

## Translation Tool

Use `AsTranslateTool()` to create an `AIFunction` that wraps DeepL text translation. Pass it to any `IChatClient` via `ChatOptions.Tools`.

```csharp
using Microsoft.Extensions.AI;
using DeepL;

// Create the DeepL translation tool
var deepLClient = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);

AIFunction translateTool = deepLClient.AsTranslateTool(
    defaultTargetLanguage: TargetLanguage.En,
    formality: Formality.More);  // Optional: formal tone

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [translateTool],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Translate 'Bonjour le monde' to German"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Rephrase Tool

Use `AsRephraseTool()` to create an `AIFunction` that wraps DeepL's Write API for text improvement.

```csharp
using Microsoft.Extensions.AI;
using DeepL;

var deepLClient = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);

AIFunction rephraseTool = deepLClient.AsRephraseTool(
    writingStyle: WritingStyle.Business,  // Optional: business style
    tone: WritingTone.Confident);         // Optional: confident tone

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [rephraseTool],
};

var response = await chatClient.GetResponseAsync(
    "Please improve this text: 'The thing is very good and I like it a lot because its nice.'",
    options);

Console.WriteLine(response.Text);
```

## Document Translation Tool

Use `AsTranslateDocumentTool()` to create an `AIFunction` that handles the full document translation workflow (upload, poll, download). Supports DOCX, PPTX, XLSX, PDF, HTML, TXT, and more.

```csharp
using Microsoft.Extensions.AI;
using DeepL;

var deepLClient = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);

AIFunction docTool = deepLClient.AsTranslateDocumentTool(
    defaultTargetLanguage: TargetLanguage.Fr);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [docTool],
};
```

!!! note
    The document translation tool accepts base64-encoded file content and returns the translated document as base64. This is best suited for agents that handle file I/O.

## Combining All Tools

You can provide all three tools simultaneously, letting the model decide which to use.

```csharp
using Microsoft.Extensions.AI;
using DeepL;

var deepLClient = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        deepLClient.AsTranslateTool(),
        deepLClient.AsRephraseTool(),
        deepLClient.AsTranslateDocumentTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "First improve the grammar of 'Me want go store tomorrow' then translate the improved version to French."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTranslateTool()` | `TranslateText` | Translates text between 30+ languages with automatic source detection |
| `AsRephraseTool()` | `RephraseText` | Improves text clarity, tone, and style using DeepL Write API |
| `AsTranslateDocumentTool()` | `TranslateDocument` | Translates documents (DOCX, PDF, TXT, etc.) with automatic polling |

### AsTranslateTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `defaultTargetLanguage` | `TargetLanguage` | `En` | Default target language when the model doesn't specify one |
| `formality` | `Formality?` | `null` | Formality level: `Default`, `Less`, `More`, `PreferLess`, `PreferMore` |

### AsRephraseTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `writingStyle` | `WritingStyle?` | `null` | Style: `Academic`, `Business`, `Casual`, `Simple`, or `Default` |
| `tone` | `WritingTone?` | `null` | Tone: `Confident`, `Diplomatic`, `Enthusiastic`, `Friendly`, or `Default` |

### AsTranslateDocumentTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `defaultTargetLanguage` | `TargetLanguage` | `En` | Default target language when the model doesn't specify one |
| `formality` | `Formality?` | `null` | Formality level for the translation |
| `pollIntervalMs` | `int` | `1000` | Polling interval in milliseconds when waiting for translation |

### Language Codes

The translation tools accept standard language codes as strings:

| Code | Language | Code | Language |
|------|----------|------|----------|
| `DE` | German | `FR` | French |
| `ES` | Spanish | `IT` | Italian |
| `PT-BR` | Portuguese (Brazil) | `PT-PT` | Portuguese (Portugal) |
| `EN-US` | English (US) | `EN-GB` | English (UK) |
| `JA` | Japanese | `ZH-HANS` | Chinese (Simplified) |
| `KO` | Korean | `RU` | Russian |

See the [DeepL documentation](https://developers.deepl.com/docs/resources/supported-languages) for the full list of 30+ supported languages.
