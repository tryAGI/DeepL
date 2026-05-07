
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A translation target specifying the desired output language and format.
    /// </summary>
    public sealed partial class VoiceTranslateJobTargetRequest
    {
        /// <summary>
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource) (beta).<br/>
        /// Example: DE
        /// </summary>
        /// <example>DE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The desired output format for the translation target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceTranslateJobTargetOutputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.VoiceTranslateJobTargetOutputType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobTargetRequest" /> class.
        /// </summary>
        /// <param name="language">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource) (beta).<br/>
        /// Example: DE
        /// </param>
        /// <param name="type">
        /// The desired output format for the translation target.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceTranslateJobTargetRequest(
            string language,
            global::DeepL.VoiceTranslateJobTargetOutputType type)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobTargetRequest" /> class.
        /// </summary>
        public VoiceTranslateJobTargetRequest()
        {
        }
    }
}