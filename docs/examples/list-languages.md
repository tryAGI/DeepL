# List Languages

Shows how to list supported languages.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

```csharp
using var client = new DeepLClient(apiKey);

// List all supported source and target languages.
var languages = await client.MetaInformation.GetLanguagesAsync();
```