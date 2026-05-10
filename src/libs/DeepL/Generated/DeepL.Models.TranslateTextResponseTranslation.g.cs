
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateTextResponseTranslation
    {
        /// <summary>
        /// The language detected in the source text. It reflects the value of the `source_lang` parameter, when specified.<br/>
        /// Example: EN
        /// </summary>
        /// <example>EN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected_source_language")]
        public string? DetectedSourceLanguage { get; set; }

        /// <summary>
        /// The translated text.<br/>
        /// Example: Hallo, Welt!
        /// </summary>
        /// <example>Hallo, Welt!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Number of characters counted by DeepL for billing purposes. Only present if the show_billed_characters parameter is set to true.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_characters")]
        public int? BilledCharacters { get; set; }

        /// <summary>
        /// Indicates the translation model used. Only present if model_type parameter is included in the request.<br/>
        /// Example: quality_optimized
        /// </summary>
        /// <example>quality_optimized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type_used")]
        public string? ModelTypeUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextResponseTranslation" /> class.
        /// </summary>
        /// <param name="detectedSourceLanguage">
        /// The language detected in the source text. It reflects the value of the `source_lang` parameter, when specified.<br/>
        /// Example: EN
        /// </param>
        /// <param name="text">
        /// The translated text.<br/>
        /// Example: Hallo, Welt!
        /// </param>
        /// <param name="billedCharacters">
        /// Number of characters counted by DeepL for billing purposes. Only present if the show_billed_characters parameter is set to true.<br/>
        /// Example: 42
        /// </param>
        /// <param name="modelTypeUsed">
        /// Indicates the translation model used. Only present if model_type parameter is included in the request.<br/>
        /// Example: quality_optimized
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateTextResponseTranslation(
            string? detectedSourceLanguage,
            string? text,
            int? billedCharacters,
            string? modelTypeUsed)
        {
            this.DetectedSourceLanguage = detectedSourceLanguage;
            this.Text = text;
            this.BilledCharacters = billedCharacters;
            this.ModelTypeUsed = modelTypeUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextResponseTranslation" /> class.
        /// </summary>
        public TranslateTextResponseTranslation()
        {
        }

    }
}