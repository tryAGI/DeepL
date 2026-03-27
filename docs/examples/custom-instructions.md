# Custom Instructions

Shows how to add free-text custom instructions to a style rule list
for fine-grained control over translation output.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

```csharp
var client = new DeepLClient(apiKey);

// Custom instructions let you provide free-text rules that
// DeepL applies during translation — for example, enforcing
// terminology conventions or formatting preferences.

// ## Create a style rule list

var styleRule = await client.StyleRules.CreateStyleRuleListAsync(
    name: "Custom Instruction Demo",
    language: StyleRuleLanguage.En);

// ## Add a custom instruction

// Each instruction has a label and a prompt describing the rule:
var instruction = await client.StyleRules.CreateCustomInstructionAsync(
    styleId: styleRule.StyleId,
    label: "Currency formatting",
    prompt: "Always place the currency symbol before the number (e.g. $100, €50).");

// ## Retrieve the instruction

var retrieved = await client.StyleRules.GetCustomInstructionAsync(
    styleId: styleRule.StyleId,
    instructionId: instruction.Id);

// ## Add a source-language-specific instruction

// You can optionally restrict an instruction to a specific
// source language:
var deInstruction = await client.StyleRules.CreateCustomInstructionAsync(
    styleId: styleRule.StyleId,
    label: "German compound nouns",
    prompt: "Keep German compound nouns as a single word in the translation.",
    sourceLanguage: "de");

// ## Clean up

await client.StyleRules.DeleteCustomInstructionAsync(
    styleId: styleRule.StyleId,
    instructionId: deInstruction.Id);

await client.StyleRules.DeleteCustomInstructionAsync(
    styleId: styleRule.StyleId,
    instructionId: instruction.Id);

await client.StyleRules.DeleteStyleRuleListAsync(
    styleId: styleRule.StyleId);
```