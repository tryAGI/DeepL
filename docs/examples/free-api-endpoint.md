# Free API Endpoint

Shows how to use the DeepL Free API endpoint instead of the Pro endpoint.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

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