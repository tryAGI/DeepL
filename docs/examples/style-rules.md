# Style Rules

Demonstrates how to create, configure, and manage style rule lists for
consistent translation output.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

```csharp
var client = new DeepLClient(apiKey);

// Style rules let you enforce terminology, formatting, and tone
// preferences across translations. They are configured per language.

// ## Create a style rule list

// Create a new style rule list for English with punctuation rules:
var created = await client.StyleRules.CreateStyleRuleListAsync(
    name: "SDK Test Rules",
    language: StyleRuleLanguage.En);

// ## List style rule lists

// Retrieve all style rule lists:
var lists = await client.StyleRules.GetStyleRuleListsAsync(detailed: true);

// ## Update configured rules

// Configure specific rule categories (7 available: DatesAndTimes,
// Formatting, Numbers, Punctuation, SpellingAndGrammar,
// StyleAndTone, Vocabulary):
var updated = await client.StyleRules.UpdateStyleRuleConfiguredRulesAsync(
    styleId: created.StyleId,
    punctuation: new ConfiguredRulesPunctuation());

// ## Clean up

await client.StyleRules.DeleteStyleRuleListAsync(
    styleId: created.StyleId);
```