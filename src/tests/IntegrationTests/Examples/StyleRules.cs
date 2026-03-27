/*
order: 85
title: Style Rules
slug: style-rules

Demonstrates how to create, configure, and manage style rule lists for
consistent translation output.
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task StyleRules()
    {
        var client = GetAuthenticatedClient();

        //// Style rules let you enforce terminology, formatting, and tone
        //// preferences across translations. They are configured per language.

        //// ## Create a style rule list

        //// Create a new style rule list for English with punctuation rules:
        var created = await client.StyleRules.CreateStyleRuleListAsync(
            name: "SDK Test Rules",
            language: StyleRuleLanguage.En);

        created.StyleId.Should().NotBeNullOrEmpty();
        created.Name.Should().Be("SDK Test Rules");
        created.Language.Should().Be(StyleRuleLanguage.En);

        //// ## List style rule lists

        //// Retrieve all style rule lists:
        var lists = await client.StyleRules.GetStyleRuleListsAsync(detailed: true);

        lists.StyleRules.Should().NotBeNull();
        lists.StyleRules!.Count.Should().BeGreaterThanOrEqualTo(1);

        //// ## Update configured rules

        //// Configure specific rule categories (7 available: DatesAndTimes,
        //// Formatting, Numbers, Punctuation, SpellingAndGrammar,
        //// StyleAndTone, Vocabulary):
        var updated = await client.StyleRules.UpdateStyleRuleConfiguredRulesAsync(
            styleId: created.StyleId,
            punctuation: new ConfiguredRulesPunctuation());

        updated.Version.Should().BeGreaterThanOrEqualTo(created.Version);

        //// ## Clean up

        await client.StyleRules.DeleteStyleRuleListAsync(
            styleId: created.StyleId);
    }
}
