# Rephrase Text

Shows how to use the DeepL Write API to rephrase text.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

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