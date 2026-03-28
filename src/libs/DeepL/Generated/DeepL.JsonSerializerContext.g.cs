
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesCalendarEraJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesCalendarEraNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesCenturiesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesCenturiesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesDateFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesDateFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesDatesInNumericalFormJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesDatesInNumericalFormNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesDecadesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesDecadesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSeparatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesHoursMinutesSeparatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesMidnightInNumeralsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesMidnightInNumeralsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonthsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonthsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitHoursJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesSingleDigitHoursNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesTimeFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesTimeFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesWritingDatesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesWritingDatesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesYearsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesDatesAndTimesYearsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingEmailAddressFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingEmailAddressFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingPhoneNumberCountryCodeFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingPhoneNumberCountryCodeFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingPhoneNumberFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingPhoneNumberFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersApproximateNumbersJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersApproximateNumbersNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersCurrencyFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersCurrencyFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersDecimalNumbersLessThanOneJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersDecimalNumbersLessThanOneNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersDecimalSeparatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersDecimalSeparatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersDimensionsSeparatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersDimensionsSeparatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersEquationFormulaReferenceJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersEquationFormulaReferenceNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersKanjiNumbersJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersKanjiNumbersNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersLargeNumberFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersLargeNumberFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersLargeSumsOfMoneyFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersListOfMeasurementsWithUnitsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersListOfMeasurementsWithUnitsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersMathematicalExpressionSpacingJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersMathematicalExpressionSpacingNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumberFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumberFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumberSeparatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumberSeparatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumbersOf5DigitsOrMoreNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumbersUpTo4DigitsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersNumbersUpTo4DigitsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersPercentageFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersPercentageFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersReferenceToSymbolJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersReferenceToSymbolNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersSpellingOutUnitsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersSpellingOutUnitsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersTemperatureFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersTemperatureFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersThousandsSeparatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersThousandsSeparatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersUnitsOfMeasureSpacingJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersUnitsOfMeasureSpacingNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersUseOfHiraganaAndKanjiJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersUseOfHiraganaAndKanjiNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersWritingNumbersJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersWritingNumbersNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersZeroFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesNumbersZeroFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAbbreviationsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAbbreviationsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAcronymsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAcronymsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAmpersandAbbreviationSpacingJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAmpersandAbbreviationSpacingNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAmpersandUsageJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationAmpersandUsageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationApostropheJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationApostropheNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationBracketJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationBracketNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationChineseMixedWithEnglishJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationChineseMixedWithEnglishNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonInHeadingJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonInHeadingNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonToReplaceVersusOrToJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationColonToReplaceVersusOrToNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterIEAndEGJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterIEAndEGNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAndSemicolonJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCommaAndSemicolonNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCornerBracketAndPeriodsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCornerBracketAndPeriodsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCornerBracketsAndPeriodsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationCornerBracketsAndPeriodsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationDashJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationDashNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEllipsisJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEllipsisNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEmDashJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEmDashNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEmphasisJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationEmphasisNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationExclamationMarksJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationExclamationMarksNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationExplanatoryNoteIndicatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationExplanatoryNoteIndicatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationFullSentenceInRoundBracketsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationFullSentenceInRoundBracketsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationHighlightingSpecificExpressionsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationHighlightingSpecificExpressionsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationJapaneseReferenceMaterialsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationJapaneseReferenceMaterialsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationParenthesesForSupplementaryInformationJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationParenthesesForSupplementaryInformationNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsAndCommasJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsAndCommasNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInAcademicDegreesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInAcademicDegreesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInDirectQuotesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInDirectQuotesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPlusSignUsageJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPlusSignUsageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationMarkJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationMarkNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostropheJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationMarkAndApostropheNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationStyleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationQuotationStyleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRangeIndicatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRangeIndicatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRelatedPhrasesIndicatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRelatedPhrasesIndicatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRoundBracketsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationRoundBracketsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSalutationJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSalutationNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSentenceBreakIndicatorJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSentenceBreakIndicatorNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSerialCommaJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSerialCommaNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSlashJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSlashNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSlashUsageJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSlashUsageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSpacingAndPunctuationJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationSpacingAndPunctuationNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationUppercaseAcronymsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesPunctuationUppercaseAcronymsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumeroJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumeroNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviationUsageJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAbbreviationUsageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsAndCedillasJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsAndCedillasNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDerJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDerNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarActivePassiveVoiceJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarActivePassiveVoiceNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAllCapsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarAllCapsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarCompleteSentencesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarCompleteSentencesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarCompoundNounsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarCompoundNounsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarConjunctionsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarConjunctionsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarContractionsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarContractionsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarEstablishedLoanwordsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarEstablishedLoanwordsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarEszettJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarEszettNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarForeignWordTranslationJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarForeignWordTranslationNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccentsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccentsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarInformalAddressPronounsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarInformalAddressPronounsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarLatinAbbreviationsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarLatinAbbreviationsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPassiveVoiceJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPassiveVoiceNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitiveJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitiveNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPersonalTitlesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPersonalTitlesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPluralizingForeignWordsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarPluralizingForeignWordsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarQuotationModificationJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarQuotationModificationNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarSpanishWordSoloJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarSpanishWordSoloNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarSpecialCharactersJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarSpecialCharactersNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarSpelledOutNumbersJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarSpelledOutNumbersNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarUmlautsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarUmlautsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwordsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwordsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAbbreviationsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAbbreviationsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAddressingNonBinaryPeopleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAddressingNonBinaryPeopleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAddressingTheReaderJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAddressingTheReaderNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAnglicismsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAnglicismsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneBinaryRepresentationOfGenderJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneBinaryRepresentationOfGenderNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneComplexSentencesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneComplexSentencesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneCountryNamesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneCountryNamesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDeclarativeEndingsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDeclarativeEndingsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDefaultFirstPersonPronounJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDefaultFirstPersonPronounNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDefaultSecondPersonPronounJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDefaultSecondPersonPronounNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDirectionalLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDirectionalLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDoubleNegativesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDoubleNegativesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneFormalityJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneFormalityNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadabilityJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadabilityNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferencesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferencesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneInstructionsStyleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneInstructionsStyleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneMixingStylesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneMixingStylesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneModalVerbsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneModalVerbsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneProximityAgreementJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneProximityAgreementNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneReaderActionRequiredJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneReaderActionRequiredNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrasesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrasesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneRedundantPhrasesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneRedundantPhrasesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneReferringToNonBinaryPeopleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneReferringToNonBinaryPeopleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneShortVsLongWordsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneShortVsLongWordsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneSimpleWordsAndSentencesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneSimpleWordsAndSentencesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneTextPositionReferencesJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneTextPositionReferencesNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneToneJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneToneNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneVerbalVsNominalStyleJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneVerbalVsNominalStyleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesVocabularyAbbreviationsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesVocabularyAbbreviationsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesVocabularyLoanwordsJsonConverter),

            typeof(global::DeepL.JsonConverters.ConfiguredRulesVocabularyLoanwordsNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.CreateGlossaryParametersEntriesFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.CreateGlossaryParametersEntriesFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.FormalityJsonConverter),

            typeof(global::DeepL.JsonConverters.FormalityNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.GlossaryEntriesFormatJsonConverter),

            typeof(global::DeepL.JsonConverters.GlossaryEntriesFormatNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.GlossarySourceLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.GlossarySourceLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.GlossaryTargetLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.GlossaryTargetLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.ModelTypeJsonConverter),

            typeof(global::DeepL.JsonConverters.ModelTypeNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.OutlineDetectionOptionStrJsonConverter),

            typeof(global::DeepL.JsonConverters.OutlineDetectionOptionStrNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.PreserveFormattingOptionStrJsonConverter),

            typeof(global::DeepL.JsonConverters.PreserveFormattingOptionStrNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.SplitSentencesOptionJsonConverter),

            typeof(global::DeepL.JsonConverters.SplitSentencesOptionNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.SourceLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.SourceLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.StyleRuleLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.StyleRuleLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.TagHandlingOptionJsonConverter),

            typeof(global::DeepL.JsonConverters.TagHandlingOptionNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.TagHandlingVersionOptionJsonConverter),

            typeof(global::DeepL.JsonConverters.TagHandlingVersionOptionNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.UsageResponseProductBillingUnitJsonConverter),

            typeof(global::DeepL.JsonConverters.UsageResponseProductBillingUnitNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.TargetLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.TargetLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.TargetLanguageWriteJsonConverter),

            typeof(global::DeepL.JsonConverters.TargetLanguageWriteNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceFormalityJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceFormalityNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceMediaContentTypeJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceMediaContentTypeNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceSourceLanguageJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceSourceLanguageNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceSourceLanguageModeJsonConverter),

            typeof(global::DeepL.JsonConverters.VoiceSourceLanguageModeNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.WritingStyleJsonConverter),

            typeof(global::DeepL.JsonConverters.WritingStyleNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.WritingToneJsonConverter),

            typeof(global::DeepL.JsonConverters.WritingToneNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.AdminUsageReportDataGroupByJsonConverter),

            typeof(global::DeepL.JsonConverters.AdminUsageReportDataGroupByNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.GetGlossaryEntriesAcceptJsonConverter),

            typeof(global::DeepL.JsonConverters.GetGlossaryEntriesAcceptNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.GetLanguagesTypeJsonConverter),

            typeof(global::DeepL.JsonConverters.GetLanguagesTypeNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.AdminGetAnalyticsGroupByJsonConverter),

            typeof(global::DeepL.JsonConverters.AdminGetAnalyticsGroupByNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.GetDocumentStatusResponseStatusJsonConverter),

            typeof(global::DeepL.JsonConverters.GetDocumentStatusResponseStatusNullableJsonConverter),

            typeof(global::DeepL.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ApiKeyUsageLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesCalendarEra), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesCalendarEra2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesCenturies), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesCenturies2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesDateFormat), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesDateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesDatesInNumericalForm), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesDatesInNumericalForm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesDecades), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesDecades2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesHoursMinutesSeparator), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesHoursMinutesSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesMidnightInNumerals), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesMidnightInNumerals2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesSingleDigitHours), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesSingleDigitHours2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesTimeFormat), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesTimeFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesWritingDates), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesWritingDates2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesDatesAndTimesYears), TypeInfoPropertyName = "ConfiguredRulesDatesAndTimesYears2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormattingEmailAddressFormat), TypeInfoPropertyName = "ConfiguredRulesFormattingEmailAddressFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat), TypeInfoPropertyName = "ConfiguredRulesFormattingPhoneNumberCountryCodeFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormattingPhoneNumberFormat), TypeInfoPropertyName = "ConfiguredRulesFormattingPhoneNumberFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit), TypeInfoPropertyName = "ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish), TypeInfoPropertyName = "ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals), TypeInfoPropertyName = "ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersApproximateNumbers), TypeInfoPropertyName = "ConfiguredRulesNumbersApproximateNumbers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersCurrencyFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersCurrencyFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersDecimalNumbersLessThanOne), TypeInfoPropertyName = "ConfiguredRulesNumbersDecimalNumbersLessThanOne2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersDecimalSeparator), TypeInfoPropertyName = "ConfiguredRulesNumbersDecimalSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersDimensionsSeparator), TypeInfoPropertyName = "ConfiguredRulesNumbersDimensionsSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersEquationFormulaReference), TypeInfoPropertyName = "ConfiguredRulesNumbersEquationFormulaReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersKanjiNumbers), TypeInfoPropertyName = "ConfiguredRulesNumbersKanjiNumbers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersLargeNumberFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersLargeNumberFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersLargeSumsOfMoney), TypeInfoPropertyName = "ConfiguredRulesNumbersLargeSumsOfMoney2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersLargeSumsOfMoneyFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersLargeSumsOfMoneyFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersListOfMeasurementsWithUnits), TypeInfoPropertyName = "ConfiguredRulesNumbersListOfMeasurementsWithUnits2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersMathematicalExpressionSpacing), TypeInfoPropertyName = "ConfiguredRulesNumbersMathematicalExpressionSpacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersNumberFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersNumberFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersNumberSeparator), TypeInfoPropertyName = "ConfiguredRulesNumbersNumberSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersNumbersOf5DigitsOrMore), TypeInfoPropertyName = "ConfiguredRulesNumbersNumbersOf5DigitsOrMore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersNumbersUpTo4Digits), TypeInfoPropertyName = "ConfiguredRulesNumbersNumbersUpTo4Digits2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersPercentageFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersPercentageFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersReferenceToSymbol), TypeInfoPropertyName = "ConfiguredRulesNumbersReferenceToSymbol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersSpellingOutUnits), TypeInfoPropertyName = "ConfiguredRulesNumbersSpellingOutUnits2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersTemperatureFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersTemperatureFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersThousandsSeparator), TypeInfoPropertyName = "ConfiguredRulesNumbersThousandsSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersUnitsOfMeasureSpacing), TypeInfoPropertyName = "ConfiguredRulesNumbersUnitsOfMeasureSpacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersUseOfHiraganaAndKanji), TypeInfoPropertyName = "ConfiguredRulesNumbersUseOfHiraganaAndKanji2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersWritingNumbers), TypeInfoPropertyName = "ConfiguredRulesNumbersWritingNumbers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesNumbersZeroFormat), TypeInfoPropertyName = "ConfiguredRulesNumbersZeroFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationAbbreviations), TypeInfoPropertyName = "ConfiguredRulesPunctuationAbbreviations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationAcronyms), TypeInfoPropertyName = "ConfiguredRulesPunctuationAcronyms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing), TypeInfoPropertyName = "ConfiguredRulesPunctuationAmpersandAbbreviationSpacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationAmpersandUsage), TypeInfoPropertyName = "ConfiguredRulesPunctuationAmpersandUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationApostrophe), TypeInfoPropertyName = "ConfiguredRulesPunctuationApostrophe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationBracket), TypeInfoPropertyName = "ConfiguredRulesPunctuationBracket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationChineseMixedWithEnglish), TypeInfoPropertyName = "ConfiguredRulesPunctuationChineseMixedWithEnglish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationColon), TypeInfoPropertyName = "ConfiguredRulesPunctuationColon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses), TypeInfoPropertyName = "ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationColonInHeading), TypeInfoPropertyName = "ConfiguredRulesPunctuationColonInHeading2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationColonToReplaceVersusOrTo), TypeInfoPropertyName = "ConfiguredRulesPunctuationColonToReplaceVersusOrTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs), TypeInfoPropertyName = "ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationCommaAfterIEAndEG), TypeInfoPropertyName = "ConfiguredRulesPunctuationCommaAfterIEAndEG2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase), TypeInfoPropertyName = "ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationCommaAndSemicolon), TypeInfoPropertyName = "ConfiguredRulesPunctuationCommaAndSemicolon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationCornerBracketAndPeriods), TypeInfoPropertyName = "ConfiguredRulesPunctuationCornerBracketAndPeriods2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationCornerBracketsAndPeriods), TypeInfoPropertyName = "ConfiguredRulesPunctuationCornerBracketsAndPeriods2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationDash), TypeInfoPropertyName = "ConfiguredRulesPunctuationDash2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationEllipsis), TypeInfoPropertyName = "ConfiguredRulesPunctuationEllipsis2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationEmDash), TypeInfoPropertyName = "ConfiguredRulesPunctuationEmDash2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationEmphasis), TypeInfoPropertyName = "ConfiguredRulesPunctuationEmphasis2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationExclamationMarks), TypeInfoPropertyName = "ConfiguredRulesPunctuationExclamationMarks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationExplanatoryNoteIndicator), TypeInfoPropertyName = "ConfiguredRulesPunctuationExplanatoryNoteIndicator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationFullSentenceInRoundBrackets), TypeInfoPropertyName = "ConfiguredRulesPunctuationFullSentenceInRoundBrackets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationHighlightingSpecificExpressions), TypeInfoPropertyName = "ConfiguredRulesPunctuationHighlightingSpecificExpressions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationJapaneseReferenceMaterials), TypeInfoPropertyName = "ConfiguredRulesPunctuationJapaneseReferenceMaterials2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation), TypeInfoPropertyName = "ConfiguredRulesPunctuationParenthesesForSupplementaryInformation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations), TypeInfoPropertyName = "ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPeriodsAndCommas), TypeInfoPropertyName = "ConfiguredRulesPunctuationPeriodsAndCommas2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPeriodsInAcademicDegrees), TypeInfoPropertyName = "ConfiguredRulesPunctuationPeriodsInAcademicDegrees2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPeriodsInDirectQuotes), TypeInfoPropertyName = "ConfiguredRulesPunctuationPeriodsInDirectQuotes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms), TypeInfoPropertyName = "ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPlusSignUsage), TypeInfoPropertyName = "ConfiguredRulesPunctuationPlusSignUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle), TypeInfoPropertyName = "ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationQuotationMark), TypeInfoPropertyName = "ConfiguredRulesPunctuationQuotationMark2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationQuotationMarkAndApostrophe), TypeInfoPropertyName = "ConfiguredRulesPunctuationQuotationMarkAndApostrophe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationQuotationStyle), TypeInfoPropertyName = "ConfiguredRulesPunctuationQuotationStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationRangeIndicator), TypeInfoPropertyName = "ConfiguredRulesPunctuationRangeIndicator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationRelatedPhrasesIndicator), TypeInfoPropertyName = "ConfiguredRulesPunctuationRelatedPhrasesIndicator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationRoundBrackets), TypeInfoPropertyName = "ConfiguredRulesPunctuationRoundBrackets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSalutation), TypeInfoPropertyName = "ConfiguredRulesPunctuationSalutation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSentenceBreakIndicator), TypeInfoPropertyName = "ConfiguredRulesPunctuationSentenceBreakIndicator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSerialComma), TypeInfoPropertyName = "ConfiguredRulesPunctuationSerialComma2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases), TypeInfoPropertyName = "ConfiguredRulesPunctuationSettingOffNonQuotedPhrases2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSlash), TypeInfoPropertyName = "ConfiguredRulesPunctuationSlash2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSlashUsage), TypeInfoPropertyName = "ConfiguredRulesPunctuationSlashUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationSpacingAndPunctuation), TypeInfoPropertyName = "ConfiguredRulesPunctuationSpacingAndPunctuation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence), TypeInfoPropertyName = "ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText), TypeInfoPropertyName = "ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers), TypeInfoPropertyName = "ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations), TypeInfoPropertyName = "ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesPunctuationUppercaseAcronyms), TypeInfoPropertyName = "ConfiguredRulesPunctuationUppercaseAcronyms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarAbbreviationUsage), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarAbbreviationUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarAccentsAndCedillas), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarAccentsAndCedillas2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarActivePassiveVoice), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarActivePassiveVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarAllCaps), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarAllCaps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarCompleteSentences), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarCompleteSentences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarCompoundNouns), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarCompoundNouns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarConjunctions), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarConjunctions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarContractions), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarContractions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarEstablishedLoanwords), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarEstablishedLoanwords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarEszett), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarEszett2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarForeignWordTranslation), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarForeignWordTranslation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarInformalAddressPronouns), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarInformalAddressPronouns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarLatinAbbreviations), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarLatinAbbreviations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarPassiveVoice), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarPassiveVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarPersonalTitles2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarPluralizingForeignWords), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarPluralizingForeignWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarQuotationModification), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarQuotationModification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarSpanishWordSolo), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarSpanishWordSolo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarSpecialCharacters), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarSpecialCharacters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarSpelledOutNumbers), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarSpelledOutNumbers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarUmlauts), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarUmlauts2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords), TypeInfoPropertyName = "ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndTone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneAbbreviations), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneAbbreviations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneAddressingNonBinaryPeople), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneAddressingNonBinaryPeople2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneAddressingTheReader), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneAddressingTheReader2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneAnglicisms), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneAnglicisms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneBinaryRepresentationOfGender), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneBinaryRepresentationOfGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneComplexSentences), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneComplexSentences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneCountryNames), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneCountryNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneDeclarativeEndings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneDirectionalLanguage), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneDirectionalLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneDoubleNegatives), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneDoubleNegatives2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneFormality), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneFormality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecified), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneGenderUnspecified2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneInstructionsStyle), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneInstructionsStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneMixingStyles), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneMixingStyles2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneModalVerbs), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneModalVerbs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle), TypeInfoPropertyName = "ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage), TypeInfoPropertyName = "ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneProximityAgreement), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneProximityAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneReaderActionRequired), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneReaderActionRequired2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneRedundantPhrases), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneRedundantPhrases2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneReferringToNonBinaryPeople), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneReferringToNonBinaryPeople2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneShortVsLongWords), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneShortVsLongWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneSimpleWordsAndSentences), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneSimpleWordsAndSentences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneTextPositionReferences), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneTextPositionReferences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneTone), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesStyleAndToneVerbalVsNominalStyle), TypeInfoPropertyName = "ConfiguredRulesStyleAndToneVerbalVsNominalStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesVocabulary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesVocabularyAbbreviations), TypeInfoPropertyName = "ConfiguredRulesVocabularyAbbreviations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ConfiguredRulesVocabularyLoanwords), TypeInfoPropertyName = "ConfiguredRulesVocabularyLoanwords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateGlossaryParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossarySourceLanguage), TypeInfoPropertyName = "GlossarySourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryTargetLanguage), TypeInfoPropertyName = "GlossaryTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateGlossaryParametersEntriesFormat), TypeInfoPropertyName = "CreateGlossaryParametersEntriesFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateMultilingualGlossaryParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.GlossaryDictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomInstructionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DocumentTranslationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DocumentKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.Formality), TypeInfoPropertyName = "Formality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryEntriesFormat), TypeInfoPropertyName = "GlossaryEntriesFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ModelType), TypeInfoPropertyName = "ModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MonolingualGlossary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossaryEntries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossaryEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntriesInformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossaryEntriesInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OutlineDetectionOptionStr), TypeInfoPropertyName = "OutlineDetectionOptionStr2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.PatchMultilingualGlossaryParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.PreserveFormattingOptionStr), TypeInfoPropertyName = "PreserveFormattingOptionStr2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.SplitSentencesOption), TypeInfoPropertyName = "SplitSentencesOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.SourceLanguage), TypeInfoPropertyName = "SourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.StyleRuleList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.StyleRuleLanguage), TypeInfoPropertyName = "StyleRuleLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.CustomInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TagHandlingOption), TypeInfoPropertyName = "TagHandlingOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TagHandlingVersionOption), TypeInfoPropertyName = "TagHandlingVersionOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.UsageResponseProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.UsageResponseProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.UsageResponseProductBillingUnit), TypeInfoPropertyName = "UsageResponseProductBillingUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TargetLanguage), TypeInfoPropertyName = "TargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TargetLanguageWrite), TypeInfoPropertyName = "TargetLanguageWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceFormality), TypeInfoPropertyName = "VoiceFormality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceMediaContentType), TypeInfoPropertyName = "VoiceMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceLanguage), TypeInfoPropertyName = "VoiceSourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceLanguageMode), TypeInfoPropertyName = "VoiceSourceLanguageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceStreamingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.WritingStyle), TypeInfoPropertyName = "WritingStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.WritingTone), TypeInfoPropertyName = "WritingTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReportData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.UsageBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReportDataGroupBy), TypeInfoPropertyName = "AdminUsageReportDataGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.KeyUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.KeyUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.KeyAndDayUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.KeyAndDayUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslateTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslateTextRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.RephraseTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.RephraseTextRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminCreateDeveloperKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminDeactivateDeveloperKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminRenameDeveloperKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminSetDeveloperKeyUsageLimitsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateStyleRuleListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.CustomInstructionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.UpdateStyleRuleListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetVoiceStreamingUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetGlossaryEntriesAccept), TypeInfoPropertyName = "GetGlossaryEntriesAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetLanguagesType), TypeInfoPropertyName = "GetLanguagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetAnalyticsGroupBy), TypeInfoPropertyName = "AdminGetAnalyticsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslateTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.TranslateTextResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslateTextResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslateDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetDocumentStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetDocumentStatusResponseStatus), TypeInfoPropertyName = "GetDocumentStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListGlossaryLanguagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.ListGlossaryLanguagesResponseSupportedLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListGlossaryLanguagesResponseSupportedLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListMultilingualGlossariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.PatchMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DeleteMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetMultilingualGlossaryEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DeleteDictionaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ReplaceDictionaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListGlossariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.MonolingualGlossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DeleteGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetGlossaryEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.RephraseTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.RephraseTextResponseImprovement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.RephraseTextResponseImprovement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetLanguagesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetStyleRuleListsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.StyleRuleList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.GlossaryDictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.MultilingualGlossaryEntriesInformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.CustomInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.UsageResponseProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.KeyUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.KeyAndDayUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.CustomInstructionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.TranslateTextResponseTranslation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.ListGlossaryLanguagesResponseSupportedLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.MultilingualGlossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.MonolingualGlossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.RephraseTextResponseImprovement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.GetLanguagesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.StyleRuleList>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}