# DeepL

[![Nuget package](https://img.shields.io/nuget/vpre/DeepL)](https://www.nuget.org/packages/DeepL/)
[![dotnet](https://github.com/tryAGI/DeepL/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/DeepL/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/DeepL)](https://github.com/tryAGI/DeepL/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official DeepL OpenAPI specification](https://raw.githubusercontent.com/DeepLcom/openapi/main/openapi.yaml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using DeepL;

using var client = new DeepLClient(apiKey);
```

<!-- EXAMPLES:START -->
### Translate Text
Shows how to translate text between languages using the DeepL API.

```csharp
using var client = new DeepLClient(apiKey);

// Translate text from English to German using the DeepL API.
var response = await client.TranslateText.TranslateTextAsync(
    request: new TranslateTextRequest
    {
        Text = ["Hello, world!"],
        TargetLang = TargetLanguage.De,
    });
```

### Rephrase Text
Shows how to use the DeepL Write API to rephrase text.

```csharp
using var client = new DeepLClient(apiKey);

// Use the DeepL Write API to rephrase text for improved style and clarity.
var response = await client.RephraseText.RephraseTextAsync(
    request: new RephraseTextRequest
    {
        Text = ["The weather is very nice today and I think we should go outside."],
        TargetLang = TargetLanguageWrite.EnUs,
    });
```

### Get Usage
Shows how to retrieve account usage information.

```csharp
using var client = new DeepLClient(apiKey);

// Retrieve your DeepL account usage (character count and limits).
var response = await client.MetaInformation.GetUsageAsync();
```

### List Languages
Shows how to list supported languages.

```csharp
using var client = new DeepLClient(apiKey);

// List all supported source and target languages.
var languages = await client.MetaInformation.GetLanguagesAsync();
```

### Translate Document
Shows how to translate a document using the upload-poll-download workflow.

```csharp
using var client = new DeepLClient(apiKey);

// DeepL's document translation follows a three-step workflow:
// 1. Upload the document and specify the target language
// 2. Poll for translation status until complete
// 3. Download the translated document

// Step 1: Upload a text file for translation.
var content = "Hello, world! This is a test document for translation."u8.ToArray();
var uploadResponse = await client.TranslateDocuments.TranslateDocumentAsync(
    targetLang: TargetLanguage.De,
    file: content,
    filename: "test.txt");

// Step 2: Poll until the document translation is complete.
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

// Step 3: Download the translated document (one-time download).
var translatedBytes = await client.TranslateDocuments.DownloadDocumentAsync(
    documentId: uploadResponse.DocumentId!,
    documentKey1: uploadResponse.DocumentKey!);

var translatedText = System.Text.Encoding.UTF8.GetString(translatedBytes);
```

### Voice Streaming
Shows how to initiate a voice streaming session for real-time translation.

```csharp
using var client = new DeepLClient(apiKey);

// The DeepL Voice API provides real-time speech translation via WebSocket.
// Step 1: Call the REST endpoint to get an ephemeral WebSocket URL and token.
var response = await client.VoiceAPI.GetVoiceStreamingUrlAsync(
    request: new GetVoiceStreamingUrlRequest
    {
        SourceMediaContentType = VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_16000,
        SourceLanguage = VoiceSourceLanguage.En,
        TargetLanguages = ["de"],
    });

// Step 2: Connect to the WebSocket URL (`response.StreamingUrl`)
// and stream audio bytes for real-time transcription and translation.
// This example only verifies the REST setup endpoint;
// actual WebSocket streaming requires a separate WebSocket client.
```

### Free API Endpoint
Shows how to use the DeepL Free API endpoint instead of the Pro endpoint.

```csharp
// DeepL offers two API tiers with different base URLs:
// - Pro:  https://api.deepl.com (default)
// - Free: https://api-free.deepl.com
//
// To use the Free API, pass the base URL to the constructor.
using var freeClient = new DeepLClient(
    apiKey: "test-key",
    baseUri: new System.Uri("https://api-free.deepl.com"));

// The Pro API is the default — no base URL needed.
using var proClient = new DeepLClient(apiKey: "test-key");
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/DeepL/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/DeepL/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
