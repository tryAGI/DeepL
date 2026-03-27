
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesPunctuation
    {
        /// <summary>
        /// Formatting options for Abbreviations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abbreviations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAbbreviationsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationAbbreviations? Abbreviations { get; set; }

        /// <summary>
        /// Formatting options for Acronyms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acronyms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAcronymsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationAcronyms? Acronyms { get; set; }

        /// <summary>
        /// Formatting options for Ampersand Abbreviation Spacing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ampersand_abbreviation_spacing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAmpersandAbbreviationSpacingJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing? AmpersandAbbreviationSpacing { get; set; }

        /// <summary>
        /// Formatting options for Ampersand Usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ampersand_usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAmpersandUsageJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationAmpersandUsage? AmpersandUsage { get; set; }

        /// <summary>
        /// Formatting options for Apostrophe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apostrophe")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationApostropheJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationApostrophe? Apostrophe { get; set; }

        /// <summary>
        /// Formatting options for Bracket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bracket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationBracketJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationBracket? Bracket { get; set; }

        /// <summary>
        /// Formatting options for Chinese Mixed With English
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chinese_mixed_with_english")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationChineseMixedWithEnglishJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationChineseMixedWithEnglish? ChineseMixedWithEnglish { get; set; }

        /// <summary>
        /// Formatting options for Colon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colon")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationColon? Colon { get; set; }

        /// <summary>
        /// Formatting options for Colon Between Hours And Minutes Or Chapters And Verses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colon_between_hours_and_minutes_or_chapters_and_verses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? ColonBetweenHoursAndMinutesOrChaptersAndVerses { get; set; }

        /// <summary>
        /// Formatting options for Colon In Heading
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colon_in_heading")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonInHeadingJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationColonInHeading? ColonInHeading { get; set; }

        /// <summary>
        /// Formatting options for Colon To Replace Versus Or To
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colon_to_replace_versus_or_to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonToReplaceVersusOrToJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationColonToReplaceVersusOrTo? ColonToReplaceVersusOrTo { get; set; }

        /// <summary>
        /// Formatting options for Comma After Conjunctive Adverbs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comma_after_conjunctive_adverbs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs? CommaAfterConjunctiveAdverbs { get; set; }

        /// <summary>
        /// Formatting options for Comma After I E And E G
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comma_after_i_e_and_e_g")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterIEAndEGJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationCommaAfterIEAndEG? CommaAfterIEAndEG { get; set; }

        /// <summary>
        /// Formatting options for Comma After Short Introductory Phrase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comma_after_short_introductory_phrase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase? CommaAfterShortIntroductoryPhrase { get; set; }

        /// <summary>
        /// Formatting options for Comma And Semicolon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comma_and_semicolon")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAndSemicolonJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationCommaAndSemicolon? CommaAndSemicolon { get; set; }

        /// <summary>
        /// Formatting options for Corner Bracket And Periods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corner_bracket_and_periods")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCornerBracketAndPeriodsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationCornerBracketAndPeriods? CornerBracketAndPeriods { get; set; }

        /// <summary>
        /// Formatting options for Corner Brackets And Periods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corner_brackets_and_periods")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCornerBracketsAndPeriodsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationCornerBracketsAndPeriods? CornerBracketsAndPeriods { get; set; }

        /// <summary>
        /// Formatting options for Dash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dash")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationDashJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationDash? Dash { get; set; }

        /// <summary>
        /// Formatting options for Ellipsis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ellipsis")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEllipsisJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationEllipsis? Ellipsis { get; set; }

        /// <summary>
        /// Formatting options for Em Dash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("em_dash")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEmDashJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationEmDash? EmDash { get; set; }

        /// <summary>
        /// Formatting options for Emphasis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emphasis")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEmphasisJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationEmphasis? Emphasis { get; set; }

        /// <summary>
        /// Formatting options for Exclamation Marks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclamation_marks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationExclamationMarksJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationExclamationMarks? ExclamationMarks { get; set; }

        /// <summary>
        /// Formatting options for Explanatory Note Indicator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanatory_note_indicator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationExplanatoryNoteIndicatorJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationExplanatoryNoteIndicator? ExplanatoryNoteIndicator { get; set; }

        /// <summary>
        /// Formatting options for Full Sentence In Round Brackets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_sentence_in_round_brackets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationFullSentenceInRoundBracketsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationFullSentenceInRoundBrackets? FullSentenceInRoundBrackets { get; set; }

        /// <summary>
        /// Formatting options for Highlighting Specific Expressions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighting_specific_expressions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationHighlightingSpecificExpressionsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationHighlightingSpecificExpressions? HighlightingSpecificExpressions { get; set; }

        /// <summary>
        /// Formatting options for Japanese Reference Materials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("japanese_reference_materials")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationJapaneseReferenceMaterialsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationJapaneseReferenceMaterials? JapaneseReferenceMaterials { get; set; }

        /// <summary>
        /// Formatting options for Parentheses For Supplementary Information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentheses_for_supplementary_information")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationParenthesesForSupplementaryInformationJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation? ParenthesesForSupplementaryInformation { get; set; }

        /// <summary>
        /// Formatting options for Passage Of Time And Movement Between Locations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passage_of_time_and_movement_between_locations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations? PassageOfTimeAndMovementBetweenLocations { get; set; }

        /// <summary>
        /// Formatting options for Periods And Commas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods_and_commas")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsAndCommasJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPeriodsAndCommas? PeriodsAndCommas { get; set; }

        /// <summary>
        /// Formatting options for Periods In Academic Degrees
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods_in_academic_degrees")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInAcademicDegreesJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPeriodsInAcademicDegrees? PeriodsInAcademicDegrees { get; set; }

        /// <summary>
        /// Formatting options for Periods In Direct Quotes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods_in_direct_quotes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInDirectQuotesJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPeriodsInDirectQuotes? PeriodsInDirectQuotes { get; set; }

        /// <summary>
        /// Formatting options for Periods In Uppercase Initialisms And Acronyms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods_in_uppercase_initialisms_and_acronyms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms? PeriodsInUppercaseInitialismsAndAcronyms { get; set; }

        /// <summary>
        /// Formatting options for Plus Sign Usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plus_sign_usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPlusSignUsageJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPlusSignUsage? PlusSignUsage { get; set; }

        /// <summary>
        /// Formatting options for Possessives Of Proper Names Ending In S Style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("possessives_of_proper_names_ending_in_s_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle? PossessivesOfProperNamesEndingInSStyle { get; set; }

        /// <summary>
        /// Formatting options for Quotation Mark
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quotation_mark")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationMarkJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationQuotationMark? QuotationMark { get; set; }

        /// <summary>
        /// Formatting options for Quotation Mark And Apostrophe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quotation_mark_and_apostrophe")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostropheJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationQuotationMarkAndApostrophe? QuotationMarkAndApostrophe { get; set; }

        /// <summary>
        /// Formatting options for Quotation Style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quotation_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationStyleJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationQuotationStyle? QuotationStyle { get; set; }

        /// <summary>
        /// Formatting options for Range Indicator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_indicator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRangeIndicatorJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationRangeIndicator? RangeIndicator { get; set; }

        /// <summary>
        /// Formatting options for Related Phrases Indicator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related_phrases_indicator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRelatedPhrasesIndicatorJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationRelatedPhrasesIndicator? RelatedPhrasesIndicator { get; set; }

        /// <summary>
        /// Formatting options for Round Brackets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("round_brackets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRoundBracketsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationRoundBrackets? RoundBrackets { get; set; }

        /// <summary>
        /// Formatting options for Salutation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salutation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSalutationJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSalutation? Salutation { get; set; }

        /// <summary>
        /// Formatting options for Sentence Break Indicator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentence_break_indicator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSentenceBreakIndicatorJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSentenceBreakIndicator? SentenceBreakIndicator { get; set; }

        /// <summary>
        /// Formatting options for Serial Comma
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial_comma")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSerialCommaJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSerialComma? SerialComma { get; set; }

        /// <summary>
        /// Formatting options for Setting Off Non Quoted Phrases
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setting_off_non_quoted_phrases")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases? SettingOffNonQuotedPhrases { get; set; }

        /// <summary>
        /// Formatting options for Slash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slash")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSlashJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSlash? Slash { get; set; }

        /// <summary>
        /// Formatting options for Slash Usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slash_usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSlashUsageJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSlashUsage? SlashUsage { get; set; }

        /// <summary>
        /// Formatting options for Spacing And Punctuation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spacing_and_punctuation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSpacingAndPunctuationJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationSpacingAndPunctuation? SpacingAndPunctuation { get; set; }

        /// <summary>
        /// Formatting options for Text In Round Brackets Referring To Previous Sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_in_round_brackets_referring_to_previous_sentence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence? TextInRoundBracketsReferringToPreviousSentence { get; set; }

        /// <summary>
        /// Formatting options for Text In Round Brackets Supplementing Preceding Text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_in_round_brackets_supplementing_preceding_text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText? TextInRoundBracketsSupplementingPrecedingText { get; set; }

        /// <summary>
        /// Formatting options for Titles Of Books And Newspapers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("titles_of_books_and_newspapers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers? TitlesOfBooksAndNewspapers { get; set; }

        /// <summary>
        /// Formatting options for Titles Of Creative Works Trade Names Laws And Regulations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("titles_of_creative_works_trade_names_laws_and_regulations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations? TitlesOfCreativeWorksTradeNamesLawsAndRegulations { get; set; }

        /// <summary>
        /// Formatting options for Uppercase Acronyms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uppercase_acronyms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationUppercaseAcronymsJsonConverter))]
        public global::DeepL.ConfiguredRulesPunctuationUppercaseAcronyms? UppercaseAcronyms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesPunctuation" /> class.
        /// </summary>
        /// <param name="abbreviations">
        /// Formatting options for Abbreviations
        /// </param>
        /// <param name="acronyms">
        /// Formatting options for Acronyms
        /// </param>
        /// <param name="ampersandAbbreviationSpacing">
        /// Formatting options for Ampersand Abbreviation Spacing
        /// </param>
        /// <param name="ampersandUsage">
        /// Formatting options for Ampersand Usage
        /// </param>
        /// <param name="apostrophe">
        /// Formatting options for Apostrophe
        /// </param>
        /// <param name="bracket">
        /// Formatting options for Bracket
        /// </param>
        /// <param name="chineseMixedWithEnglish">
        /// Formatting options for Chinese Mixed With English
        /// </param>
        /// <param name="colon">
        /// Formatting options for Colon
        /// </param>
        /// <param name="colonBetweenHoursAndMinutesOrChaptersAndVerses">
        /// Formatting options for Colon Between Hours And Minutes Or Chapters And Verses
        /// </param>
        /// <param name="colonInHeading">
        /// Formatting options for Colon In Heading
        /// </param>
        /// <param name="colonToReplaceVersusOrTo">
        /// Formatting options for Colon To Replace Versus Or To
        /// </param>
        /// <param name="commaAfterConjunctiveAdverbs">
        /// Formatting options for Comma After Conjunctive Adverbs
        /// </param>
        /// <param name="commaAfterIEAndEG">
        /// Formatting options for Comma After I E And E G
        /// </param>
        /// <param name="commaAfterShortIntroductoryPhrase">
        /// Formatting options for Comma After Short Introductory Phrase
        /// </param>
        /// <param name="commaAndSemicolon">
        /// Formatting options for Comma And Semicolon
        /// </param>
        /// <param name="cornerBracketAndPeriods">
        /// Formatting options for Corner Bracket And Periods
        /// </param>
        /// <param name="cornerBracketsAndPeriods">
        /// Formatting options for Corner Brackets And Periods
        /// </param>
        /// <param name="dash">
        /// Formatting options for Dash
        /// </param>
        /// <param name="ellipsis">
        /// Formatting options for Ellipsis
        /// </param>
        /// <param name="emDash">
        /// Formatting options for Em Dash
        /// </param>
        /// <param name="emphasis">
        /// Formatting options for Emphasis
        /// </param>
        /// <param name="exclamationMarks">
        /// Formatting options for Exclamation Marks
        /// </param>
        /// <param name="explanatoryNoteIndicator">
        /// Formatting options for Explanatory Note Indicator
        /// </param>
        /// <param name="fullSentenceInRoundBrackets">
        /// Formatting options for Full Sentence In Round Brackets
        /// </param>
        /// <param name="highlightingSpecificExpressions">
        /// Formatting options for Highlighting Specific Expressions
        /// </param>
        /// <param name="japaneseReferenceMaterials">
        /// Formatting options for Japanese Reference Materials
        /// </param>
        /// <param name="parenthesesForSupplementaryInformation">
        /// Formatting options for Parentheses For Supplementary Information
        /// </param>
        /// <param name="passageOfTimeAndMovementBetweenLocations">
        /// Formatting options for Passage Of Time And Movement Between Locations
        /// </param>
        /// <param name="periodsAndCommas">
        /// Formatting options for Periods And Commas
        /// </param>
        /// <param name="periodsInAcademicDegrees">
        /// Formatting options for Periods In Academic Degrees
        /// </param>
        /// <param name="periodsInDirectQuotes">
        /// Formatting options for Periods In Direct Quotes
        /// </param>
        /// <param name="periodsInUppercaseInitialismsAndAcronyms">
        /// Formatting options for Periods In Uppercase Initialisms And Acronyms
        /// </param>
        /// <param name="plusSignUsage">
        /// Formatting options for Plus Sign Usage
        /// </param>
        /// <param name="possessivesOfProperNamesEndingInSStyle">
        /// Formatting options for Possessives Of Proper Names Ending In S Style
        /// </param>
        /// <param name="quotationMark">
        /// Formatting options for Quotation Mark
        /// </param>
        /// <param name="quotationMarkAndApostrophe">
        /// Formatting options for Quotation Mark And Apostrophe
        /// </param>
        /// <param name="quotationStyle">
        /// Formatting options for Quotation Style
        /// </param>
        /// <param name="rangeIndicator">
        /// Formatting options for Range Indicator
        /// </param>
        /// <param name="relatedPhrasesIndicator">
        /// Formatting options for Related Phrases Indicator
        /// </param>
        /// <param name="roundBrackets">
        /// Formatting options for Round Brackets
        /// </param>
        /// <param name="salutation">
        /// Formatting options for Salutation
        /// </param>
        /// <param name="sentenceBreakIndicator">
        /// Formatting options for Sentence Break Indicator
        /// </param>
        /// <param name="serialComma">
        /// Formatting options for Serial Comma
        /// </param>
        /// <param name="settingOffNonQuotedPhrases">
        /// Formatting options for Setting Off Non Quoted Phrases
        /// </param>
        /// <param name="slash">
        /// Formatting options for Slash
        /// </param>
        /// <param name="slashUsage">
        /// Formatting options for Slash Usage
        /// </param>
        /// <param name="spacingAndPunctuation">
        /// Formatting options for Spacing And Punctuation
        /// </param>
        /// <param name="textInRoundBracketsReferringToPreviousSentence">
        /// Formatting options for Text In Round Brackets Referring To Previous Sentence
        /// </param>
        /// <param name="textInRoundBracketsSupplementingPrecedingText">
        /// Formatting options for Text In Round Brackets Supplementing Preceding Text
        /// </param>
        /// <param name="titlesOfBooksAndNewspapers">
        /// Formatting options for Titles Of Books And Newspapers
        /// </param>
        /// <param name="titlesOfCreativeWorksTradeNamesLawsAndRegulations">
        /// Formatting options for Titles Of Creative Works Trade Names Laws And Regulations
        /// </param>
        /// <param name="uppercaseAcronyms">
        /// Formatting options for Uppercase Acronyms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfiguredRulesPunctuation(
            global::DeepL.ConfiguredRulesPunctuationAbbreviations? abbreviations,
            global::DeepL.ConfiguredRulesPunctuationAcronyms? acronyms,
            global::DeepL.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing? ampersandAbbreviationSpacing,
            global::DeepL.ConfiguredRulesPunctuationAmpersandUsage? ampersandUsage,
            global::DeepL.ConfiguredRulesPunctuationApostrophe? apostrophe,
            global::DeepL.ConfiguredRulesPunctuationBracket? bracket,
            global::DeepL.ConfiguredRulesPunctuationChineseMixedWithEnglish? chineseMixedWithEnglish,
            global::DeepL.ConfiguredRulesPunctuationColon? colon,
            global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? colonBetweenHoursAndMinutesOrChaptersAndVerses,
            global::DeepL.ConfiguredRulesPunctuationColonInHeading? colonInHeading,
            global::DeepL.ConfiguredRulesPunctuationColonToReplaceVersusOrTo? colonToReplaceVersusOrTo,
            global::DeepL.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs? commaAfterConjunctiveAdverbs,
            global::DeepL.ConfiguredRulesPunctuationCommaAfterIEAndEG? commaAfterIEAndEG,
            global::DeepL.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase? commaAfterShortIntroductoryPhrase,
            global::DeepL.ConfiguredRulesPunctuationCommaAndSemicolon? commaAndSemicolon,
            global::DeepL.ConfiguredRulesPunctuationCornerBracketAndPeriods? cornerBracketAndPeriods,
            global::DeepL.ConfiguredRulesPunctuationCornerBracketsAndPeriods? cornerBracketsAndPeriods,
            global::DeepL.ConfiguredRulesPunctuationDash? dash,
            global::DeepL.ConfiguredRulesPunctuationEllipsis? ellipsis,
            global::DeepL.ConfiguredRulesPunctuationEmDash? emDash,
            global::DeepL.ConfiguredRulesPunctuationEmphasis? emphasis,
            global::DeepL.ConfiguredRulesPunctuationExclamationMarks? exclamationMarks,
            global::DeepL.ConfiguredRulesPunctuationExplanatoryNoteIndicator? explanatoryNoteIndicator,
            global::DeepL.ConfiguredRulesPunctuationFullSentenceInRoundBrackets? fullSentenceInRoundBrackets,
            global::DeepL.ConfiguredRulesPunctuationHighlightingSpecificExpressions? highlightingSpecificExpressions,
            global::DeepL.ConfiguredRulesPunctuationJapaneseReferenceMaterials? japaneseReferenceMaterials,
            global::DeepL.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation? parenthesesForSupplementaryInformation,
            global::DeepL.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations? passageOfTimeAndMovementBetweenLocations,
            global::DeepL.ConfiguredRulesPunctuationPeriodsAndCommas? periodsAndCommas,
            global::DeepL.ConfiguredRulesPunctuationPeriodsInAcademicDegrees? periodsInAcademicDegrees,
            global::DeepL.ConfiguredRulesPunctuationPeriodsInDirectQuotes? periodsInDirectQuotes,
            global::DeepL.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms? periodsInUppercaseInitialismsAndAcronyms,
            global::DeepL.ConfiguredRulesPunctuationPlusSignUsage? plusSignUsage,
            global::DeepL.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle? possessivesOfProperNamesEndingInSStyle,
            global::DeepL.ConfiguredRulesPunctuationQuotationMark? quotationMark,
            global::DeepL.ConfiguredRulesPunctuationQuotationMarkAndApostrophe? quotationMarkAndApostrophe,
            global::DeepL.ConfiguredRulesPunctuationQuotationStyle? quotationStyle,
            global::DeepL.ConfiguredRulesPunctuationRangeIndicator? rangeIndicator,
            global::DeepL.ConfiguredRulesPunctuationRelatedPhrasesIndicator? relatedPhrasesIndicator,
            global::DeepL.ConfiguredRulesPunctuationRoundBrackets? roundBrackets,
            global::DeepL.ConfiguredRulesPunctuationSalutation? salutation,
            global::DeepL.ConfiguredRulesPunctuationSentenceBreakIndicator? sentenceBreakIndicator,
            global::DeepL.ConfiguredRulesPunctuationSerialComma? serialComma,
            global::DeepL.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases? settingOffNonQuotedPhrases,
            global::DeepL.ConfiguredRulesPunctuationSlash? slash,
            global::DeepL.ConfiguredRulesPunctuationSlashUsage? slashUsage,
            global::DeepL.ConfiguredRulesPunctuationSpacingAndPunctuation? spacingAndPunctuation,
            global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence? textInRoundBracketsReferringToPreviousSentence,
            global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText? textInRoundBracketsSupplementingPrecedingText,
            global::DeepL.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers? titlesOfBooksAndNewspapers,
            global::DeepL.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations? titlesOfCreativeWorksTradeNamesLawsAndRegulations,
            global::DeepL.ConfiguredRulesPunctuationUppercaseAcronyms? uppercaseAcronyms)
        {
            this.Abbreviations = abbreviations;
            this.Acronyms = acronyms;
            this.AmpersandAbbreviationSpacing = ampersandAbbreviationSpacing;
            this.AmpersandUsage = ampersandUsage;
            this.Apostrophe = apostrophe;
            this.Bracket = bracket;
            this.ChineseMixedWithEnglish = chineseMixedWithEnglish;
            this.Colon = colon;
            this.ColonBetweenHoursAndMinutesOrChaptersAndVerses = colonBetweenHoursAndMinutesOrChaptersAndVerses;
            this.ColonInHeading = colonInHeading;
            this.ColonToReplaceVersusOrTo = colonToReplaceVersusOrTo;
            this.CommaAfterConjunctiveAdverbs = commaAfterConjunctiveAdverbs;
            this.CommaAfterIEAndEG = commaAfterIEAndEG;
            this.CommaAfterShortIntroductoryPhrase = commaAfterShortIntroductoryPhrase;
            this.CommaAndSemicolon = commaAndSemicolon;
            this.CornerBracketAndPeriods = cornerBracketAndPeriods;
            this.CornerBracketsAndPeriods = cornerBracketsAndPeriods;
            this.Dash = dash;
            this.Ellipsis = ellipsis;
            this.EmDash = emDash;
            this.Emphasis = emphasis;
            this.ExclamationMarks = exclamationMarks;
            this.ExplanatoryNoteIndicator = explanatoryNoteIndicator;
            this.FullSentenceInRoundBrackets = fullSentenceInRoundBrackets;
            this.HighlightingSpecificExpressions = highlightingSpecificExpressions;
            this.JapaneseReferenceMaterials = japaneseReferenceMaterials;
            this.ParenthesesForSupplementaryInformation = parenthesesForSupplementaryInformation;
            this.PassageOfTimeAndMovementBetweenLocations = passageOfTimeAndMovementBetweenLocations;
            this.PeriodsAndCommas = periodsAndCommas;
            this.PeriodsInAcademicDegrees = periodsInAcademicDegrees;
            this.PeriodsInDirectQuotes = periodsInDirectQuotes;
            this.PeriodsInUppercaseInitialismsAndAcronyms = periodsInUppercaseInitialismsAndAcronyms;
            this.PlusSignUsage = plusSignUsage;
            this.PossessivesOfProperNamesEndingInSStyle = possessivesOfProperNamesEndingInSStyle;
            this.QuotationMark = quotationMark;
            this.QuotationMarkAndApostrophe = quotationMarkAndApostrophe;
            this.QuotationStyle = quotationStyle;
            this.RangeIndicator = rangeIndicator;
            this.RelatedPhrasesIndicator = relatedPhrasesIndicator;
            this.RoundBrackets = roundBrackets;
            this.Salutation = salutation;
            this.SentenceBreakIndicator = sentenceBreakIndicator;
            this.SerialComma = serialComma;
            this.SettingOffNonQuotedPhrases = settingOffNonQuotedPhrases;
            this.Slash = slash;
            this.SlashUsage = slashUsage;
            this.SpacingAndPunctuation = spacingAndPunctuation;
            this.TextInRoundBracketsReferringToPreviousSentence = textInRoundBracketsReferringToPreviousSentence;
            this.TextInRoundBracketsSupplementingPrecedingText = textInRoundBracketsSupplementingPrecedingText;
            this.TitlesOfBooksAndNewspapers = titlesOfBooksAndNewspapers;
            this.TitlesOfCreativeWorksTradeNamesLawsAndRegulations = titlesOfCreativeWorksTradeNamesLawsAndRegulations;
            this.UppercaseAcronyms = uppercaseAcronyms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesPunctuation" /> class.
        /// </summary>
        public ConfiguredRulesPunctuation()
        {
        }
    }
}