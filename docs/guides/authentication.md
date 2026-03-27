# Authentication

The DeepL SDK uses API key authentication. DeepL uses a custom `DeepL-Auth-Key` authorization scheme instead of standard `Bearer`. The SDK handles this automatically -- you pass the API key and a `PrepareRequest` hook converts the `Authorization: Bearer <key>` header to `Authorization: DeepL-Auth-Key <key>`.

You can obtain an API key from your [DeepL account](https://www.deepl.com/your-account/keys).

## Basic Usage

```csharp
using DeepL;

var client = new DeepLClient(apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!);
```

## Free vs Pro API

DeepL offers both Free and Pro API plans. The Free API uses a different base URL (`https://api-free.deepl.com`). If you are using a Free API key (ending in `:fx`), configure the base URL:

```csharp
var client = new DeepLClient(
    apiKey: Environment.GetEnvironmentVariable("DEEPL_API_KEY")!,
    baseUri: new Uri("https://api-free.deepl.com"));
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `DEEPL_API_KEY` | Your DeepL API key |
