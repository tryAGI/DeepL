
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesStyleAndTone
    {
        /// <summary>
        /// Formatting options for Abbreviations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abbreviations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAbbreviationsJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneAbbreviations? Abbreviations { get; set; }

        /// <summary>
        /// Formatting options for Addressing Non Binary People
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addressing_non_binary_people")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAddressingNonBinaryPeopleJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneAddressingNonBinaryPeople? AddressingNonBinaryPeople { get; set; }

        /// <summary>
        /// Formatting options for Addressing The Reader
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addressing_the_reader")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAddressingTheReaderJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneAddressingTheReader? AddressingTheReader { get; set; }

        /// <summary>
        /// Formatting options for Anglicisms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anglicisms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneAnglicismsJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneAnglicisms? Anglicisms { get; set; }

        /// <summary>
        /// Formatting options for Binary Representation Of Gender
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary_representation_of_gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneBinaryRepresentationOfGenderJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneBinaryRepresentationOfGender? BinaryRepresentationOfGender { get; set; }

        /// <summary>
        /// Formatting options for Complex Sentences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complex_sentences")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneComplexSentencesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneComplexSentences? ComplexSentences { get; set; }

        /// <summary>
        /// Formatting options for Country Names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_names")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneCountryNamesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneCountryNames? CountryNames { get; set; }

        /// <summary>
        /// Formatting options for Declarative Endings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declarative_endings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDeclarativeEndingsJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings? DeclarativeEndings { get; set; }

        /// <summary>
        /// Formatting options for Default First Person Pronoun
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_first_person_pronoun")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDefaultFirstPersonPronounJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun? DefaultFirstPersonPronoun { get; set; }

        /// <summary>
        /// Formatting options for Default Second Person Pronoun
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_second_person_pronoun")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDefaultSecondPersonPronounJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun? DefaultSecondPersonPronoun { get; set; }

        /// <summary>
        /// Formatting options for Directional Language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directional_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDirectionalLanguageJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneDirectionalLanguage? DirectionalLanguage { get; set; }

        /// <summary>
        /// Formatting options for Double Negatives
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("double_negatives")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneDoubleNegativesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneDoubleNegatives? DoubleNegatives { get; set; }

        /// <summary>
        /// Formatting options for Formality
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneFormalityJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneFormality? Formality { get; set; }

        /// <summary>
        /// Formatting options for Gender Neutral Language Readability
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender_neutral_language_readability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadabilityJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability? GenderNeutralLanguageReadability { get; set; }

        /// <summary>
        /// Formatting options for Gender Unspecified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender_unspecified")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecified? GenderUnspecified { get; set; }

        /// <summary>
        /// Formatting options for Gender Unspecified Or Mixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender_unspecified_or_mixed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? GenderUnspecifiedOrMixed { get; set; }

        /// <summary>
        /// Formatting options for Idioms Colloquialisms And Culture Specific References
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idioms_colloquialisms_and_culture_specific_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferencesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences? IdiomsColloquialismsAndCultureSpecificReferences { get; set; }

        /// <summary>
        /// Formatting options for Inflected Words Masculine Noun Agreement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inflected_words_masculine_noun_agreement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement? InflectedWordsMasculineNounAgreement { get; set; }

        /// <summary>
        /// Formatting options for Instructions Style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneInstructionsStyleJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneInstructionsStyle? InstructionsStyle { get; set; }

        /// <summary>
        /// Formatting options for Mixing Styles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mixing_styles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneMixingStylesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneMixingStyles? MixingStyles { get; set; }

        /// <summary>
        /// Formatting options for Modal Verbs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modal_verbs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneModalVerbsJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneModalVerbs? ModalVerbs { get; set; }

        /// <summary>
        /// Formatting options for Personal Vs Impersonal Style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personal_vs_impersonal_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyleJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle? PersonalVsImpersonalStyle { get; set; }

        /// <summary>
        /// Formatting options for Positive Vs Negative Language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_vs_negative_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguageJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage? PositiveVsNegativeLanguage { get; set; }

        /// <summary>
        /// Formatting options for Proximity Agreement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proximity_agreement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneProximityAgreementJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneProximityAgreement? ProximityAgreement { get; set; }

        /// <summary>
        /// Formatting options for Reader Action Required
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reader_action_required")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneReaderActionRequiredJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneReaderActionRequired? ReaderActionRequired { get; set; }

        /// <summary>
        /// Formatting options for Redundant Introductory Phrases
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redundant_introductory_phrases")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrasesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases? RedundantIntroductoryPhrases { get; set; }

        /// <summary>
        /// Formatting options for Redundant Phrases
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redundant_phrases")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneRedundantPhrasesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneRedundantPhrases? RedundantPhrases { get; set; }

        /// <summary>
        /// Formatting options for Referring To Non Binary People
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referring_to_non_binary_people")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneReferringToNonBinaryPeopleJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneReferringToNonBinaryPeople? ReferringToNonBinaryPeople { get; set; }

        /// <summary>
        /// Formatting options for Short Vs Long Words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_vs_long_words")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneShortVsLongWordsJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneShortVsLongWords? ShortVsLongWords { get; set; }

        /// <summary>
        /// Formatting options for Simple Words And Sentences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simple_words_and_sentences")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneSimpleWordsAndSentencesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneSimpleWordsAndSentences? SimpleWordsAndSentences { get; set; }

        /// <summary>
        /// Formatting options for Text Position References
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_position_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneTextPositionReferencesJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneTextPositionReferences? TextPositionReferences { get; set; }

        /// <summary>
        /// Formatting options for Tone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneToneJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneTone? Tone { get; set; }

        /// <summary>
        /// Formatting options for Verbal Vs Nominal Style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbal_vs_nominal_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesStyleAndToneVerbalVsNominalStyleJsonConverter))]
        public global::DeepL.ConfiguredRulesStyleAndToneVerbalVsNominalStyle? VerbalVsNominalStyle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesStyleAndTone" /> class.
        /// </summary>
        /// <param name="abbreviations">
        /// Formatting options for Abbreviations
        /// </param>
        /// <param name="addressingNonBinaryPeople">
        /// Formatting options for Addressing Non Binary People
        /// </param>
        /// <param name="addressingTheReader">
        /// Formatting options for Addressing The Reader
        /// </param>
        /// <param name="anglicisms">
        /// Formatting options for Anglicisms
        /// </param>
        /// <param name="binaryRepresentationOfGender">
        /// Formatting options for Binary Representation Of Gender
        /// </param>
        /// <param name="complexSentences">
        /// Formatting options for Complex Sentences
        /// </param>
        /// <param name="countryNames">
        /// Formatting options for Country Names
        /// </param>
        /// <param name="declarativeEndings">
        /// Formatting options for Declarative Endings
        /// </param>
        /// <param name="defaultFirstPersonPronoun">
        /// Formatting options for Default First Person Pronoun
        /// </param>
        /// <param name="defaultSecondPersonPronoun">
        /// Formatting options for Default Second Person Pronoun
        /// </param>
        /// <param name="directionalLanguage">
        /// Formatting options for Directional Language
        /// </param>
        /// <param name="doubleNegatives">
        /// Formatting options for Double Negatives
        /// </param>
        /// <param name="formality">
        /// Formatting options for Formality
        /// </param>
        /// <param name="genderNeutralLanguageReadability">
        /// Formatting options for Gender Neutral Language Readability
        /// </param>
        /// <param name="genderUnspecified">
        /// Formatting options for Gender Unspecified
        /// </param>
        /// <param name="genderUnspecifiedOrMixed">
        /// Formatting options for Gender Unspecified Or Mixed
        /// </param>
        /// <param name="idiomsColloquialismsAndCultureSpecificReferences">
        /// Formatting options for Idioms Colloquialisms And Culture Specific References
        /// </param>
        /// <param name="inflectedWordsMasculineNounAgreement">
        /// Formatting options for Inflected Words Masculine Noun Agreement
        /// </param>
        /// <param name="instructionsStyle">
        /// Formatting options for Instructions Style
        /// </param>
        /// <param name="mixingStyles">
        /// Formatting options for Mixing Styles
        /// </param>
        /// <param name="modalVerbs">
        /// Formatting options for Modal Verbs
        /// </param>
        /// <param name="personalVsImpersonalStyle">
        /// Formatting options for Personal Vs Impersonal Style
        /// </param>
        /// <param name="positiveVsNegativeLanguage">
        /// Formatting options for Positive Vs Negative Language
        /// </param>
        /// <param name="proximityAgreement">
        /// Formatting options for Proximity Agreement
        /// </param>
        /// <param name="readerActionRequired">
        /// Formatting options for Reader Action Required
        /// </param>
        /// <param name="redundantIntroductoryPhrases">
        /// Formatting options for Redundant Introductory Phrases
        /// </param>
        /// <param name="redundantPhrases">
        /// Formatting options for Redundant Phrases
        /// </param>
        /// <param name="referringToNonBinaryPeople">
        /// Formatting options for Referring To Non Binary People
        /// </param>
        /// <param name="shortVsLongWords">
        /// Formatting options for Short Vs Long Words
        /// </param>
        /// <param name="simpleWordsAndSentences">
        /// Formatting options for Simple Words And Sentences
        /// </param>
        /// <param name="textPositionReferences">
        /// Formatting options for Text Position References
        /// </param>
        /// <param name="tone">
        /// Formatting options for Tone
        /// </param>
        /// <param name="verbalVsNominalStyle">
        /// Formatting options for Verbal Vs Nominal Style
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfiguredRulesStyleAndTone(
            global::DeepL.ConfiguredRulesStyleAndToneAbbreviations? abbreviations,
            global::DeepL.ConfiguredRulesStyleAndToneAddressingNonBinaryPeople? addressingNonBinaryPeople,
            global::DeepL.ConfiguredRulesStyleAndToneAddressingTheReader? addressingTheReader,
            global::DeepL.ConfiguredRulesStyleAndToneAnglicisms? anglicisms,
            global::DeepL.ConfiguredRulesStyleAndToneBinaryRepresentationOfGender? binaryRepresentationOfGender,
            global::DeepL.ConfiguredRulesStyleAndToneComplexSentences? complexSentences,
            global::DeepL.ConfiguredRulesStyleAndToneCountryNames? countryNames,
            global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings? declarativeEndings,
            global::DeepL.ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun? defaultFirstPersonPronoun,
            global::DeepL.ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun? defaultSecondPersonPronoun,
            global::DeepL.ConfiguredRulesStyleAndToneDirectionalLanguage? directionalLanguage,
            global::DeepL.ConfiguredRulesStyleAndToneDoubleNegatives? doubleNegatives,
            global::DeepL.ConfiguredRulesStyleAndToneFormality? formality,
            global::DeepL.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability? genderNeutralLanguageReadability,
            global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecified? genderUnspecified,
            global::DeepL.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? genderUnspecifiedOrMixed,
            global::DeepL.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences? idiomsColloquialismsAndCultureSpecificReferences,
            global::DeepL.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement? inflectedWordsMasculineNounAgreement,
            global::DeepL.ConfiguredRulesStyleAndToneInstructionsStyle? instructionsStyle,
            global::DeepL.ConfiguredRulesStyleAndToneMixingStyles? mixingStyles,
            global::DeepL.ConfiguredRulesStyleAndToneModalVerbs? modalVerbs,
            global::DeepL.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle? personalVsImpersonalStyle,
            global::DeepL.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage? positiveVsNegativeLanguage,
            global::DeepL.ConfiguredRulesStyleAndToneProximityAgreement? proximityAgreement,
            global::DeepL.ConfiguredRulesStyleAndToneReaderActionRequired? readerActionRequired,
            global::DeepL.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases? redundantIntroductoryPhrases,
            global::DeepL.ConfiguredRulesStyleAndToneRedundantPhrases? redundantPhrases,
            global::DeepL.ConfiguredRulesStyleAndToneReferringToNonBinaryPeople? referringToNonBinaryPeople,
            global::DeepL.ConfiguredRulesStyleAndToneShortVsLongWords? shortVsLongWords,
            global::DeepL.ConfiguredRulesStyleAndToneSimpleWordsAndSentences? simpleWordsAndSentences,
            global::DeepL.ConfiguredRulesStyleAndToneTextPositionReferences? textPositionReferences,
            global::DeepL.ConfiguredRulesStyleAndToneTone? tone,
            global::DeepL.ConfiguredRulesStyleAndToneVerbalVsNominalStyle? verbalVsNominalStyle)
        {
            this.Abbreviations = abbreviations;
            this.AddressingNonBinaryPeople = addressingNonBinaryPeople;
            this.AddressingTheReader = addressingTheReader;
            this.Anglicisms = anglicisms;
            this.BinaryRepresentationOfGender = binaryRepresentationOfGender;
            this.ComplexSentences = complexSentences;
            this.CountryNames = countryNames;
            this.DeclarativeEndings = declarativeEndings;
            this.DefaultFirstPersonPronoun = defaultFirstPersonPronoun;
            this.DefaultSecondPersonPronoun = defaultSecondPersonPronoun;
            this.DirectionalLanguage = directionalLanguage;
            this.DoubleNegatives = doubleNegatives;
            this.Formality = formality;
            this.GenderNeutralLanguageReadability = genderNeutralLanguageReadability;
            this.GenderUnspecified = genderUnspecified;
            this.GenderUnspecifiedOrMixed = genderUnspecifiedOrMixed;
            this.IdiomsColloquialismsAndCultureSpecificReferences = idiomsColloquialismsAndCultureSpecificReferences;
            this.InflectedWordsMasculineNounAgreement = inflectedWordsMasculineNounAgreement;
            this.InstructionsStyle = instructionsStyle;
            this.MixingStyles = mixingStyles;
            this.ModalVerbs = modalVerbs;
            this.PersonalVsImpersonalStyle = personalVsImpersonalStyle;
            this.PositiveVsNegativeLanguage = positiveVsNegativeLanguage;
            this.ProximityAgreement = proximityAgreement;
            this.ReaderActionRequired = readerActionRequired;
            this.RedundantIntroductoryPhrases = redundantIntroductoryPhrases;
            this.RedundantPhrases = redundantPhrases;
            this.ReferringToNonBinaryPeople = referringToNonBinaryPeople;
            this.ShortVsLongWords = shortVsLongWords;
            this.SimpleWordsAndSentences = simpleWordsAndSentences;
            this.TextPositionReferences = textPositionReferences;
            this.Tone = tone;
            this.VerbalVsNominalStyle = verbalVsNominalStyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesStyleAndTone" /> class.
        /// </summary>
        public ConfiguredRulesStyleAndTone()
        {
        }
    }
}