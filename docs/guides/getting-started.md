# Getting Started

## Installation

```bash
dotnet add package DeepL
```

## Authentication

DeepL uses a custom `DeepL-Auth-Key` authentication scheme. The SDK handles this automatically — just pass your API key:

```csharp
using DeepL;

var apiKey = Environment.GetEnvironmentVariable("DEEPL_API_KEY")!;
var client = new DeepLClient(apiKey);
```

## Translate Text

```csharp
var response = await client.TranslateText.TranslateTextAsync(
    request: new TranslateTextRequest
    {
        Text = ["Hello, world!"],
        TargetLang = TargetLanguage.De,
    });

Console.WriteLine(response.Translations[0].Text);
// Output: "Hallo, Welt!"
```

## Rephrase Text (Write API)

```csharp
var response = await client.RephraseText.RephraseTextAsync(
    request: new RephraseTextRequest
    {
        Text = ["The weather is very nice today."],
        TargetLang = TargetLanguageWrite.EnUs,
    });

Console.WriteLine(response.Improvements[0].Text);
```

## Translate Documents

```csharp
// 1. Upload
var fileBytes = File.ReadAllBytes("document.docx");
var upload = await client.TranslateDocuments.TranslateDocumentAsync(
    targetLang: TargetLanguage.Fr,
    file: fileBytes,
    filename: "document.docx");

// 2. Poll until done
GetDocumentStatusResponse status;
do
{
    await Task.Delay(2000);
    status = await client.TranslateDocuments.GetDocumentStatusAsync(
        upload.DocumentId!, upload.DocumentKey!);
}
while (status.Status is GetDocumentStatusResponseStatus.Queued
    or GetDocumentStatusResponseStatus.Translating);

// 3. Download translated document
var translated = await client.TranslateDocuments.DownloadDocumentAsync(
    upload.DocumentId!, upload.DocumentKey!);
File.WriteAllBytes("document_fr.docx", translated);
```

## Account Usage

```csharp
var usage = await client.MetaInformation.GetUsageAsync();
Console.WriteLine($"Characters used: {usage.CharacterCount}");
Console.WriteLine($"Limit: {usage.CharacterLimit}");
```

## Supported Languages

```csharp
var languages = await client.MetaInformation.GetLanguagesAsync();
foreach (var lang in languages)
{
    Console.WriteLine($"{lang.Language}: {lang.Name}");
}
```

## Sub-client Pattern

DeepL's API is organized into tagged groups, each exposed as a sub-client:

| Sub-client | Purpose |
|-----------|---------|
| `client.TranslateText` | Text translation |
| `client.RephraseText` | Write API (rephrasing) |
| `client.TranslateDocuments` | Document translation (upload/poll/download) |
| `client.MetaInformation` | Usage stats and language list |
| `client.ManageMultilingualGlossaries` | Glossary management (v3) |
| `client.ManageGlossaries` | Glossary management (v2, legacy) |
| `client.StyleRules` | Style rules (v3) |
| `client.VoiceAPI` | Real-time voice streaming (v3) |
| `client.AdminApi` | Developer key management |

## Free vs Pro API

DeepL has two API endpoints:
- **Pro:** `https://api.deepl.com` (default)
- **Free:** `https://api-free.deepl.com`

To use the Free API, configure the base URL:

```csharp
var client = new DeepLClient(apiKey, baseUri: new Uri("https://api-free.deepl.com"));
```
