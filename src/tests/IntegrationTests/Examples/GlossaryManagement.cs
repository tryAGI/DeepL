/*
order: 80
title: Glossary Management
slug: glossary-management

Shows how to create, list, and use multilingual glossaries (v3 API).
*/

namespace DeepL.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateAndUseGlossary()
    {
        using var client = GetAuthenticatedClient();

        //// Create a multilingual glossary with English-to-German entries.
        //// Entries use TSV format: source<TAB>target, one pair per line.
        var glossary = await client.ManageMultilingualGlossaries.CreateMultilingualGlossaryAsync(
            name: "Test Glossary",
            dictionaries:
            [
                new GlossaryDictionary
                {
                    SourceLang = GlossarySourceLanguage.En,
                    TargetLang = GlossaryTargetLanguage.De,
                    Entries = "API\tSchnittstelle\nSDK\tEntwicklungspaket",
                    EntriesFormat = GlossaryEntriesFormat.Tsv,
                },
            ]);

        glossary.GlossaryId.Should().NotBeNullOrEmpty();
        glossary.Name.Should().Be("Test Glossary");

        try
        {
            //// List all glossaries on the account.
            var list = await client.ManageMultilingualGlossaries.ListMultilingualGlossariesAsync();
            list.Glossaries.Should().NotBeEmpty();

            //// Get entries for a specific language pair.
            var entries = await client.ManageMultilingualGlossaries.GetMultilingualGlossaryEntriesAsync(
                glossaryId: glossary.GlossaryId!,
                sourceLang: GlossarySourceLanguage.En,
                targetLang: GlossaryTargetLanguage.De);

            entries.Entries.Should().NotBeNullOrEmpty();

            //// Translate text using the glossary for consistent terminology.
            //// Note: source_lang is required when using a glossary.
            var translation = await client.TranslateText.TranslateTextAsync(
                request: new TranslateTextRequest
                {
                    Text = ["The API and SDK are well documented."],
                    SourceLang = SourceLanguage.En,
                    TargetLang = TargetLanguage.De,
                    GlossaryId = glossary.GlossaryId,
                });

            translation.Translations.Should().NotBeEmpty();
            translation.Translations![0].Text.Should().NotBeNullOrEmpty();
        }
        finally
        {
            //// Clean up: delete the test glossary.
            await client.ManageMultilingualGlossaries.DeleteMultilingualGlossaryAsync(
                glossaryId: glossary.GlossaryId!);
        }
    }

    [TestMethod]
    public async Task ListGlossaryLanguagePairs()
    {
        using var client = GetAuthenticatedClient();

        //// List all supported glossary language pairs (v2 API).
        var pairs = await client.ManageGlossaries.ListGlossaryLanguagesAsync();

        pairs.SupportedLanguages.Should().NotBeEmpty();
    }
}
