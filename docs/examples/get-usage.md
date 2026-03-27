# Get Usage

Shows how to retrieve account usage information.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

```csharp
using var client = new DeepLClient(apiKey);

// Retrieve your DeepL account usage (character count and limits).
var response = await client.MetaInformation.GetUsageAsync();
```