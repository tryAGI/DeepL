# Translate Text

Shows how to translate text between languages using the DeepL API.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

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