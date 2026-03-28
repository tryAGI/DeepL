# CLAUDE.md — DeepL SDK

## Overview

Auto-generated C# SDK for [DeepL](https://www.deepl.com/) — translation, text rephrasing (Write API), document translation, multilingual glossaries, style rules, voice API, and account management.
OpenAPI spec from the official [DeepLcom/openapi](https://github.com/DeepLcom/openapi) repo.

## Build & Test

```bash
dotnet build DeepL.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (converted to `DeepL-Auth-Key` scheme via PrepareRequest hook):

```csharp
var client = new DeepLClient(apiKey); // DEEPL_API_KEY env var
```

## Key Files

- `src/libs/DeepL/openapi.yaml` — OpenAPI spec (downloaded from DeepLcom/openapi)
- `src/libs/DeepL/generate.sh` — Downloads spec, fixes allOf string types, runs autosdk with `--security-scheme`
- `src/libs/DeepL/Generated/` — **Never edit** — auto-generated code
- `src/libs/DeepL/Extensions/DeepLClient.Auth.cs` — PrepareRequest hook: `Bearer → DeepL-Auth-Key`
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies fixes via `yq` and `--security-scheme`:

**CLI flags:**
- `--security-scheme Http:Header:Bearer` — Overrides spec's `apiKey` auth with standard HTTP bearer

**Pre-generation (`yq`):**
1. **allOf string flattening:** Flattens `allOf`-wrapping-string schemas (CommaSeparatedList, TagList types) to avoid C# reserved keyword `string` as property name

## Auth Hook

DeepL uses `Authorization: DeepL-Auth-Key <key>` (not `Bearer`). The `PrepareRequest` hook in `Extensions/DeepLClient.Auth.cs` rewrites the scheme:

```csharp
partial void PrepareRequest(HttpClient client, HttpRequestMessage request)
{
    if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
    {
        request.Headers.Authorization =
            new AuthenticationHeaderValue("DeepL-Auth-Key", apiKey);
    }
}
```

> **Note:** `--security-scheme ApiKey:Header:<name>` cannot express DeepL's auth because it uses a custom scheme name in the `Authorization` header (not a separate custom header).

## Sub-client Pattern

DeepL API has tagged operations generating sub-clients:
- `client.TranslateText.TranslateTextAsync(...)` — Text translation
- `client.RephraseText.RephraseTextAsync(...)` — Write API (rephrasing)
- `client.TranslateDocuments.TranslateDocumentAsync(...)` — Document translation
- `client.MetaInformation.GetUsageAsync()` — Account usage
- `client.MetaInformation.GetLanguagesAsync()` — Supported languages
- `client.ManageMultilingualGlossaries.*` — Glossary management (v3)
- `client.StyleRules.*` — Style rule management (v3)
- `client.VoiceAPI.*` — Voice streaming (v3)
- `client.AdminApi.*` — Developer key management

## Voice API Notes

The Voice API provides **real-time speech translation** via WebSocket:
1. REST endpoint (`GetVoiceStreamingUrlAsync`) returns an ephemeral `wss://` URL + token
2. Client connects to WebSocket and streams audio bytes
3. Server returns transcription + multi-language translations in real-time

**Not ISpeechToTextClient compatible** — the bi-directional WebSocket streaming pattern doesn't map to MEAI's single-request transcription model. Use the SDK's native `client.VoiceAPI.GetVoiceStreamingUrlAsync()` + a WebSocket client.

## Document Translation Workflow

Three-step async pattern:
1. **Upload:** `client.TranslateDocuments.TranslateDocumentAsync(targetLang, fileBytes, filename)` → returns `DocumentId` + `DocumentKey`
2. **Poll:** `client.TranslateDocuments.GetDocumentStatusAsync(docId, docKey)` → check `Status` (Queued → Translating → Done)
3. **Download:** `client.TranslateDocuments.DownloadDocumentAsync(docId, docKey)` → returns `byte[]` (one-time download)
