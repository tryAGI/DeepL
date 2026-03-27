
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
    /// </summary>
    public sealed partial class ConfiguredRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dates_and_times")]
        public global::DeepL.ConfiguredRulesDatesAndTimes? DatesAndTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting")]
        public global::DeepL.ConfiguredRulesFormatting? Formatting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numbers")]
        public global::DeepL.ConfiguredRulesNumbers? Numbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuation")]
        public global::DeepL.ConfiguredRulesPunctuation? Punctuation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_and_grammar")]
        public global::DeepL.ConfiguredRulesSpellingAndGrammar? SpellingAndGrammar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_and_tone")]
        public global::DeepL.ConfiguredRulesStyleAndTone? StyleAndTone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocabulary")]
        public global::DeepL.ConfiguredRulesVocabulary? Vocabulary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRules" /> class.
        /// </summary>
        /// <param name="datesAndTimes"></param>
        /// <param name="formatting"></param>
        /// <param name="numbers"></param>
        /// <param name="punctuation"></param>
        /// <param name="spellingAndGrammar"></param>
        /// <param name="styleAndTone"></param>
        /// <param name="vocabulary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfiguredRules(
            global::DeepL.ConfiguredRulesDatesAndTimes? datesAndTimes,
            global::DeepL.ConfiguredRulesFormatting? formatting,
            global::DeepL.ConfiguredRulesNumbers? numbers,
            global::DeepL.ConfiguredRulesPunctuation? punctuation,
            global::DeepL.ConfiguredRulesSpellingAndGrammar? spellingAndGrammar,
            global::DeepL.ConfiguredRulesStyleAndTone? styleAndTone,
            global::DeepL.ConfiguredRulesVocabulary? vocabulary)
        {
            this.DatesAndTimes = datesAndTimes;
            this.Formatting = formatting;
            this.Numbers = numbers;
            this.Punctuation = punctuation;
            this.SpellingAndGrammar = spellingAndGrammar;
            this.StyleAndTone = styleAndTone;
            this.Vocabulary = vocabulary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRules" /> class.
        /// </summary>
        public ConfiguredRules()
        {
        }
    }
}