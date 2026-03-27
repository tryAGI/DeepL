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
- `src/libs/DeepL/generate.sh` — Downloads spec, fixes auth + allOf string types, runs autosdk
- `src/libs/DeepL/Generated/` — **Never edit** — auto-generated code
- `src/libs/DeepL/Extensions/DeepLClient.Auth.cs` — PrepareRequest hook: `Bearer → DeepL-Auth-Key`
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- DeepL uses `DeepL-Auth-Key <key>` auth header (not standard `Bearer`)
- `generate.sh` converts `apiKey` security scheme to `http/bearer` for AutoSDK
- `PrepareRequest` hook rewrites `Authorization: Bearer <key>` to `Authorization: DeepL-Auth-Key <key>`
- `generate.sh` also flattens `allOf`-wrapping-string schemas (CommaSeparatedList, TagList types) to avoid reserved keyword codegen issues

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
