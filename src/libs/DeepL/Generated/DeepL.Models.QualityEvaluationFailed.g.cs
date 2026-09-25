
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityEvaluationFailed
    {
        /// <summary>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </summary>
        /// <example>04DE5AD98A02647D83285A36021911C6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationFailedStatusJsonConverter))]
        public global::DeepL.QualityEvaluationFailedStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.QualityEvaluationFailedError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationFailed" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="error"></param>
        /// <param name="status">
        /// Example: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationFailed(
            string jobId,
            global::DeepL.QualityEvaluationFailedError error,
            global::DeepL.QualityEvaluationFailedStatus status)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationFailed" /> class.
        /// </summary>
        public QualityEvaluationFailed()
        {
        }

    }
}