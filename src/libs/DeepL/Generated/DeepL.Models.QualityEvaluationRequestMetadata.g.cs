
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Job-level metadata.
    /// </summary>
    public sealed partial class QualityEvaluationRequestMetadata
    {
        /// <summary>
        /// Language code of the source text. See [Supported language pairs](/api-reference/quality-evaluation/submit#supported-language-pairs).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLanguage { get; set; }

        /// <summary>
        /// Language code of the translated text. See [Supported language pairs](/api-reference/quality-evaluation/submit#supported-language-pairs).<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationRequestMetadata" /> class.
        /// </summary>
        /// <param name="sourceLanguage">
        /// Language code of the source text. See [Supported language pairs](/api-reference/quality-evaluation/submit#supported-language-pairs).<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLanguage">
        /// Language code of the translated text. See [Supported language pairs](/api-reference/quality-evaluation/submit#supported-language-pairs).<br/>
        /// Example: de
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationRequestMetadata(
            string sourceLanguage,
            string targetLanguage)
        {
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationRequestMetadata" /> class.
        /// </summary>
        public QualityEvaluationRequestMetadata()
        {
        }

    }
}