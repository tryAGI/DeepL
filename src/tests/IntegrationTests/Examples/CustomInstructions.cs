/*
order: 86
title: Custom Instructions
slug: custom-instructions

Shows how to add free-text custom instructions to a style rule list
for fine-grained control over translation output.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CustomInstructions()
    {
        var client = GetAuthenticatedClient();

        //// Custom instructions let you provide free-text rules that
        //// DeepL applies during translation — for example, enforcing
        //// terminology conventions or formatting preferences.

        //// ## Create a style rule list

        var styleRule = await client.StyleRules.CreateStyleRuleListAsync(
            name: "Custom Instruction Demo",
            language: StyleRuleLanguage.En);

        //// ## Add a custom instruction

        //// Each instruction has a label and a prompt describing the rule:
        var instruction = await client.StyleRules.CreateCustomInstructionAsync(
            styleId: styleRule.StyleId,
            label: "Currency formatting",
            prompt: "Always place the currency symbol before the number (e.g. $100, €50).");

        instruction.Id.Should().NotBeNullOrEmpty();
        instruction.Label.Should().Be("Currency formatting");
        instruction.Prompt.Should().Contain("currency symbol");

        //// ## Retrieve the instruction

        var retrieved = await client.StyleRules.GetCustomInstructionAsync(
            styleId: styleRule.StyleId,
            instructionId: instruction.Id);

        retrieved.Id.Should().Be(instruction.Id);

        //// ## Add a source-language-specific instruction

        //// You can optionally restrict an instruction to a specific
        //// source language:
        var deInstruction = await client.StyleRules.CreateCustomInstructionAsync(
            styleId: styleRule.StyleId,
            label: "German compound nouns",
            prompt: "Keep German compound nouns as a single word in the translation.",
            sourceLanguage: "de");

        deInstruction.SourceLanguage.Should().Be("de");

        //// ## Clean up

        await client.StyleRules.DeleteCustomInstructionAsync(
            styleId: styleRule.StyleId,
            instructionId: deInstruction.Id);

        await client.StyleRules.DeleteCustomInstructionAsync(
            styleId: styleRule.StyleId,
            instructionId: instruction.Id);

        await client.StyleRules.DeleteStyleRuleListAsync(
            styleId: styleRule.StyleId);
    }
}
