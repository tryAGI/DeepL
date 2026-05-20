
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceTranslateJobStatusResponse
    {
        /// <summary>
        /// The unique identifier of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// The product identifier.<br/>
        /// Example: voice
        /// </summary>
        /// <example>voice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// The operation identifier.<br/>
        /// Example: translate
        /// </summary>
        /// <example>translate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; }

        /// <summary>
        /// When the job was created (ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the job was last updated (ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.JobUsage Usage { get; set; }

        /// <summary>
        /// Metadata about the uploaded source audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.JobSourceFileResponse SourceFile { get; set; }

        /// <summary>
        /// Processing parameters as applied to the voice translation job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.VoiceTranslateJobParametersResponse Parameters { get; set; }

        /// <summary>
        /// The translation targets as specified in the create request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResponse> Targets { get; set; }

        /// <summary>
        /// Per-target processing results, in the same order as the `targets` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobStatusResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The unique identifier of the job.
        /// </param>
        /// <param name="product">
        /// The product identifier.<br/>
        /// Example: voice
        /// </param>
        /// <param name="operation">
        /// The operation identifier.<br/>
        /// Example: translate
        /// </param>
        /// <param name="createdAt">
        /// When the job was created (ISO 8601).
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated (ISO 8601).
        /// </param>
        /// <param name="usage"></param>
        /// <param name="sourceFile">
        /// Metadata about the uploaded source audio file.
        /// </param>
        /// <param name="parameters">
        /// Processing parameters as applied to the voice translation job.
        /// </param>
        /// <param name="targets">
        /// The translation targets as specified in the create request.
        /// </param>
        /// <param name="results">
        /// Per-target processing results, in the same order as the `targets` array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceTranslateJobStatusResponse(
            global::System.Guid jobId,
            string product,
            string operation,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::DeepL.JobUsage usage,
            global::DeepL.JobSourceFileResponse sourceFile,
            global::DeepL.VoiceTranslateJobParametersResponse parameters,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResponse> targets,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResult> results)
        {
            this.JobId = jobId;
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.SourceFile = sourceFile ?? throw new global::System.ArgumentNullException(nameof(sourceFile));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobStatusResponse" /> class.
        /// </summary>
        public VoiceTranslateJobStatusResponse()
        {
        }

    }
}