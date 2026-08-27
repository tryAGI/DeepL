
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A reference to a translation memory export job.
    /// </summary>
    public sealed partial class CreateTranslationMemoryExport
    {
        /// <summary>
        /// The identifier of the export job. Use it to poll the job's status.<br/>
        /// Example: 7c2e5a91-3b8d-4f16-8e0a-6d4c2b7f9a13
        /// </summary>
        /// <example>7c2e5a91-3b8d-4f16-8e0a-6d4c2b7f9a13</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.CreateTranslationMemoryExportParameters Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryExport" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The identifier of the export job. Use it to poll the job's status.<br/>
        /// Example: 7c2e5a91-3b8d-4f16-8e0a-6d4c2b7f9a13
        /// </param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslationMemoryExport(
            global::System.Guid jobId,
            global::DeepL.CreateTranslationMemoryExportParameters parameters)
        {
            this.JobId = jobId;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryExport" /> class.
        /// </summary>
        public CreateTranslationMemoryExport()
        {
        }

    }
}