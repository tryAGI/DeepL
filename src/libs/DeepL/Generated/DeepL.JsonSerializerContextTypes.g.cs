
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ApiKey? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ApiKeyUsageLimits? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRules? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimes? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesCalendarEra? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesCenturies? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesDateFormat? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesDatesInNumericalForm? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesDecades? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesHoursMinutesSeparator? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesMidnightInNumerals? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesSingleDigitHours? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesTimeFormat? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesWritingDates? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesDatesAndTimesYears? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormatting? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormattingEmailAddressFormat? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormattingPhoneNumberFormat? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbers? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersApproximateNumbers? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersCurrencyFormat? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersDecimalNumbersLessThanOne? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersDecimalSeparator? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersDimensionsSeparator? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersEquationFormulaReference? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersKanjiNumbers? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersLargeNumberFormat? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersLargeSumsOfMoney? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersLargeSumsOfMoneyFormat? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersListOfMeasurementsWithUnits? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersMathematicalExpressionSpacing? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersNumberFormat? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersNumberSeparator? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersNumbersOf5DigitsOrMore? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersNumbersUpTo4Digits? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersPercentageFormat? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersReferenceToSymbol? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersSpellingOutUnits? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersTemperatureFormat? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersThousandsSeparator? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersUnitsOfMeasureSpacing? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersUseOfHiraganaAndKanji? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersWritingNumbers? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesNumbersZeroFormat? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuation? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationAbbreviations? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationAcronyms? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationAmpersandUsage? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationApostrophe? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationBracket? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationChineseMixedWithEnglish? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationColon? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationColonInHeading? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationColonToReplaceVersusOrTo? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationCommaAfterIEAndEG? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationCommaAndSemicolon? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationCornerBracketAndPeriods? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationCornerBracketsAndPeriods? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationDash? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationEllipsis? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationEmDash? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationEmphasis? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationExclamationMarks? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationExplanatoryNoteIndicator? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationFullSentenceInRoundBrackets? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationHighlightingSpecificExpressions? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationJapaneseReferenceMaterials? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPeriodsAndCommas? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPeriodsInAcademicDegrees? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPeriodsInDirectQuotes? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPlusSignUsage? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationQuotationMark? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationQuotationMarkAndApostrophe? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationQuotationStyle? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationRangeIndicator? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationRelatedPhrasesIndicator? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationRoundBrackets? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSalutation? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSentenceBreakIndicator? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSerialComma? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSlash? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSlashUsage? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationSpacingAndPunctuation? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesPunctuationUppercaseAcronyms? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammar? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarAbbreviationUsage? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarAccentsAndCedillas? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCéder? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarActivePassiveVoice? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarAllCaps? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarCompleteSentences? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarCompoundNouns? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarConjunctions? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarContractions? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarEstablishedLoanwords? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarEszett? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarForeignWordTranslation? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarInformalAddressPronouns? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarLatinAbbreviations? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarPassiveVoice? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarPluralizingForeignWords? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarQuotationModification? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarSpanishWordSolo? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarSpecialCharacters? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarSpelledOutNumbers? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarUmlauts? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndTone? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneAbbreviations? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneAddressingNonBinaryPeople? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneAddressingTheReader? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneAnglicisms? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneBinaryRepresentationOfGender? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneComplexSentences? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneCountryNames? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneDirectionalLanguage? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneDoubleNegatives? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneFormality? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecified? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneInstructionsStyle? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneMixingStyles? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneModalVerbs? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneProximityAgreement? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneReaderActionRequired? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneRedundantPhrases? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneReferringToNonBinaryPeople? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneShortVsLongWords? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneSimpleWordsAndSentences? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneTextPositionReferences? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneTone? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesStyleAndToneVerbalVsNominalStyle? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesVocabulary? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesVocabularyAbbreviations? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ConfiguredRulesVocabularyLoanwords? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateGlossaryParameters? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GlossarySourceLanguage? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GlossaryTargetLanguage? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateGlossaryParametersEntriesFormat? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateMultilingualGlossaryParameters? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GlossaryDictionary>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GlossaryDictionary? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CustomInstruction? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.StyleProfile? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.StyleRuleList? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.StyleRuleLanguage? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.CustomInstruction>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.DocumentTranslationError? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.DocumentKey? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.Formality? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GlossaryEntriesFormat? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ModelType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.MonolingualGlossary? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.MultilingualGlossary? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.MultilingualGlossaryEntries? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.MultilingualGlossaryEntriesResponse? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntriesInformation>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.MultilingualGlossaryEntriesInformation? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.OutlineDetectionOptionStr? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.PatchMultilingualGlossaryParameters? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateSpokenTermsParameters? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.SpokenTermsListInput? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.PatchSpokenTermsParameters? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.PutSpokenTermsListParameters? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.SpokenTerms? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.SpokenTermsList>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.SpokenTermsList? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.SpokenTermsEntries? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.PreserveFormattingOptionStr? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.SplitSentencesOption? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemory? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemorySourceLanguage? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetLanguage>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryTargetLanguage? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemorySegment? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetSegment>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryTargetSegment? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateTranslationMemoryExport? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateTranslationMemoryExportParameters? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJob? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobOperation? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobSourceFile? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobParameters? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryJobResult>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobResult? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobResultStatus? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobResultStatusMetadata? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslationMemoryJobResultError? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TagHandlingOption? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TagHandlingVersionOption? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TargetLanguageWrite? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UsageResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.UsageResponseProduct>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UsageResponseProduct? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UsageResponseProductBillingUnit? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceFormality? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceMessageFormat? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTargetMediaVoice? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceSourceMediaContentType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceSourceLanguage? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceSourceLanguageMode? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTargetLanguage>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTargetLanguage? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTargetMediaLanguage>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTargetMediaLanguage? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTargetMediaContentType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceStreamingResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.WritingStyle? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.WritingTone? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminUsageReport? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminUsageReportData? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UsageBreakdown? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminUsageReportDataGroupBy? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.KeyUsageItem>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.KeyUsageItem? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.KeyAndDayUsageItem>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.KeyAndDayUsageItem? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CustomTagUsageReport? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CustomTagUsageReportData? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CustomTagUsageReportDataAggregateBy? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.CustomTagUsageItem>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CustomTagUsageItem? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CustomTagBreakdown? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.InfrastructureErrorResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.InfrastructureErrorResponseError? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ErrorResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobSourceContentType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.JobSourceFileRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.JobSourceFileResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobTargetOutputType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobParametersRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AllOf<string, object>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobParametersResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobTargetRequest? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobTargetResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateCreateJobRequest? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetRequest>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateCreateJobResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.JobUsage? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ResultStatus? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobTargetResult? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.VoiceTranslateJobStatusResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResponse>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResult>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationProcessing? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationProcessingStatus? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationDone? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationDoneStatus? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSegment>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationSegment? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationFailed? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationFailedStatus? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationFailedError? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationAppliedGlossaryTermPair>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationAppliedGlossaryTermPair? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationIssue>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationIssue? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationSpan? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationIssueType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationIssueSubType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationIssueSeverity? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.QualityEvaluationApiError? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminCreateDeveloperKeyRequest? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminDeactivateDeveloperKeyRequest? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminRenameDeveloperKeyRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminSetDeveloperKeyUsageLimitsRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateTextRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateTextRequest2? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateDocumentRequest? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.RephraseTextRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.RephraseTextRequest2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CorrectTextRequest? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CorrectTextRequest2? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateTranslationMemoryImportRequest? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateTranslationMemoryImportRequestSourceFile? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateTranslationMemoryImportRequestParameters? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateStyleProfileRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UpdateStyleProfileRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateStyleRuleListRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.CreateStyleRuleListRequestCustomInstruction>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateStyleRuleListRequestCustomInstruction? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UpdateStyleRuleListRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateCustomInstructionRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.UpdateCustomInstructionRequest? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetVoiceStreamingUrlRequest? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminGetAnalyticsGroupBy? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminGetCustomTagAnalyticsAggregateBy? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesV2Type? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesResource? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GetLanguagesIncludeItem>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesIncludeItem? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.CreateVoiceTranslateJobIncludeItem>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateVoiceTranslateJobIncludeItem? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GetVoiceTranslateJobStatusIncludeItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetVoiceTranslateJobStatusIncludeItem? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminGetAnalyticsResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.AdminGetCustomTagAnalyticsResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.ApiKey>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateTextResponse? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.TranslateTextResponseTranslation>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateTextResponseTranslation? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateTextResponseTranslationTagHandlingVersion? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.TranslateDocumentResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetDocumentStatusResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetDocumentStatusResponseStatus? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListGlossaryLanguagesResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.ListGlossaryLanguagesResponseSupportedLanguage>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListGlossaryLanguagesResponseSupportedLanguage? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListGlossaryLanguagesResponse2? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateMultilingualGlossaryResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListMultilingualGlossariesResponse? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossary>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListMultilingualGlossariesResponse2? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetMultilingualGlossaryResponse? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.PatchMultilingualGlossaryResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.DeleteMultilingualGlossaryResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetMultilingualGlossaryEntriesResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntries>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetMultilingualGlossaryEntriesResponse2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.DeleteDictionaryResponse? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ReplaceDictionaryResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateGlossaryResponse? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListGlossariesResponse? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.MonolingualGlossary>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListGlossariesResponse2? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetGlossaryResponse? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.DeleteGlossaryResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetGlossaryEntriesResponse? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.RephraseTextResponse? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.RephraseTextResponseImprovement>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.RephraseTextResponseImprovement? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CorrectTextResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.CorrectTextResponseImprovement>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CorrectTextResponseImprovement? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GetLanguagesV2ResponseItem>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesV2ResponseItem? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListSpokenTermsResponse? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.SpokenTerms>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GetLanguageResourcesResponseItem>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguageResourcesResponseItem? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguageResourcesResponseItemName? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GetLanguageResourcesResponseItemFeature>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguageResourcesResponseItemFeature? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguageResourcesResponseItemFeatureName? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesResponseItem? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesResponseItemStatus? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::DeepL.GetLanguagesResponseItemFeatures2>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesResponseItemFeatures2? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetLanguagesResponseItemFeaturesStatus? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListTranslationMemoriesResponse? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.TranslationMemory>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.CreateTranslationMemoryImportResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetTranslationMemorySegmentsResponse? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.TranslationMemorySegment>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.ListStyleProfilesResponse? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.StyleProfile>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.GetStyleRuleListsResponse? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepL.StyleRuleList>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>? Type408 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GlossaryDictionary>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.CustomInstruction>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.MultilingualGlossaryEntriesInformation>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.SpokenTermsListInput>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.SpokenTermsList>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.TranslationMemoryTargetLanguage>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.TranslationMemoryTargetSegment>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.TranslationMemoryJobResult>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.UsageResponseProduct>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.VoiceTargetLanguage>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.VoiceTargetMediaLanguage>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.KeyUsageItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.KeyAndDayUsageItem>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.CustomTagUsageItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.VoiceTranslateJobTargetRequest>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.VoiceTranslateJobTargetResponse>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.VoiceTranslateJobTargetResult>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.QualityEvaluationSegment>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.QualityEvaluationAppliedGlossaryTermPair>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.QualityEvaluationIssue>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.QualityEvaluationSpan>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.CreateStyleRuleListRequestCustomInstruction>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GetLanguagesIncludeItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.CreateVoiceTranslateJobIncludeItem>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GetVoiceTranslateJobStatusIncludeItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.ApiKey>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.TranslateTextResponseTranslation>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.ListGlossaryLanguagesResponseSupportedLanguage>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.MultilingualGlossary>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.MultilingualGlossaryEntries>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.MonolingualGlossary>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.RephraseTextResponseImprovement>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.CorrectTextResponseImprovement>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GetLanguagesV2ResponseItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.SpokenTerms>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GetLanguageResourcesResponseItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GetLanguageResourcesResponseItemFeature>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.GetLanguagesResponseItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.TranslationMemory>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.TranslationMemorySegment>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.StyleProfile>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.StyleRuleList>? ListType43 { get; set; }
    }
}