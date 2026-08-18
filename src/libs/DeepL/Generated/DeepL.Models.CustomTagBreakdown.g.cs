
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Breakdown of usage by category for a custom tag.
    /// </summary>
    public sealed partial class CustomTagBreakdown
    {
        /// <summary>
        /// Total number of characters used across character-based services. Voice usage is reported in minutes and is not included in this total.<br/>
        /// Example: 380
        /// </summary>
        /// <example>380</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_characters")]
        public int? TotalCharacters { get; set; }

        /// <summary>
        /// Number of characters used for text translation.<br/>
        /// Example: 380
        /// </summary>
        /// <example>380</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_translation_characters")]
        public int? TextTranslationCharacters { get; set; }

        /// <summary>
        /// Number of characters used for text improvement.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_improvement_characters")]
        public int? TextImprovementCharacters { get; set; }

        /// <summary>
        /// Duration of speech-to-text usage in minutes.<br/>
        /// Example: 12.5
        /// </summary>
        /// <example>12.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_minutes")]
        public double? SpeechToTextMinutes { get; set; }

        /// <summary>
        /// Duration of speech-to-speech usage in minutes.<br/>
        /// Example: 4.2
        /// </summary>
        /// <example>4.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_speech_minutes")]
        public double? SpeechToSpeechMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagBreakdown" /> class.
        /// </summary>
        /// <param name="totalCharacters">
        /// Total number of characters used across character-based services. Voice usage is reported in minutes and is not included in this total.<br/>
        /// Example: 380
        /// </param>
        /// <param name="textTranslationCharacters">
        /// Number of characters used for text translation.<br/>
        /// Example: 380
        /// </param>
        /// <param name="textImprovementCharacters">
        /// Number of characters used for text improvement.<br/>
        /// Example: 0
        /// </param>
        /// <param name="speechToTextMinutes">
        /// Duration of speech-to-text usage in minutes.<br/>
        /// Example: 12.5
        /// </param>
        /// <param name="speechToSpeechMinutes">
        /// Duration of speech-to-speech usage in minutes.<br/>
        /// Example: 4.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTagBreakdown(
            int? totalCharacters,
            int? textTranslationCharacters,
            int? textImprovementCharacters,
            double? speechToTextMinutes,
            double? speechToSpeechMinutes)
        {
            this.TotalCharacters = totalCharacters;
            this.TextTranslationCharacters = textTranslationCharacters;
            this.TextImprovementCharacters = textImprovementCharacters;
            this.SpeechToTextMinutes = speechToTextMinutes;
            this.SpeechToSpeechMinutes = speechToSpeechMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagBreakdown" /> class.
        /// </summary>
        public CustomTagBreakdown()
        {
        }

    }
}