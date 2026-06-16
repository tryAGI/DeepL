
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationRequest
    {
        /// <summary>
        /// Job-level metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.QualityEvaluationRequestMetadata Metadata { get; set; }

        /// <summary>
        /// The segment pairs to evaluate. Up to 500 segments per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationRequestSegment> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Job-level metadata.
        /// </param>
        /// <param name="segments">
        /// The segment pairs to evaluate. Up to 500 segments per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationRequest(
            global::DeepL.QualityEvaluationRequestMetadata metadata,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationRequestSegment> segments)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationRequest" /> class.
        /// </summary>
        public QualityEvaluationRequest()
        {
        }

    }
}