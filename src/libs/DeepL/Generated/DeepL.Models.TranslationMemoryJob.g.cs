
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The state of a translation memory import or export job. Fields that do not apply to the job's<br/>
    /// `operation` are omitted.
    /// </summary>
    public sealed partial class TranslationMemoryJob
    {
        /// <summary>
        /// The identifier of the job.<br/>
        /// Example: 0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40
        /// </summary>
        /// <example>0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// The DeepL product the job belongs to. Always `translation_memory`.<br/>
        /// Example: translation_memory
        /// </summary>
        /// <example>translation_memory</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// Which kind of job this is.<br/>
        /// Example: import
        /// </summary>
        /// <example>import</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.TranslationMemoryJobOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.TranslationMemoryJobOperation Operation { get; set; }

        /// <summary>
        /// The time the job was created, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-08-06T15:04:25.223Z
        /// </summary>
        /// <example>2026-08-06T15:04:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// The time the job last changed state, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-08-06T15:06:11.418Z
        /// </summary>
        /// <example>2026-08-06T15:06:11.418Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedTime { get; set; }

        /// <summary>
        /// The file declared when the import job was created. Omitted for export jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_file")]
        public global::DeepL.TranslationMemoryJobSourceFile? SourceFile { get; set; }

        /// <summary>
        /// The parameters the job was created with. Import jobs report `display_name`; export jobs report<br/>
        /// `translation_memory_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.TranslationMemoryJobParameters Parameters { get; set; }

        /// <summary>
        /// The job's outcome. This array always holds exactly one entry. It is an array so that jobs<br/>
        /// producing multiple outputs can be represented without a breaking change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryJobResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJob" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The identifier of the job.<br/>
        /// Example: 0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40
        /// </param>
        /// <param name="product">
        /// The DeepL product the job belongs to. Always `translation_memory`.<br/>
        /// Example: translation_memory
        /// </param>
        /// <param name="operation">
        /// Which kind of job this is.<br/>
        /// Example: import
        /// </param>
        /// <param name="creationTime">
        /// The time the job was created, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-08-06T15:04:25.223Z
        /// </param>
        /// <param name="updatedTime">
        /// The time the job last changed state, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-08-06T15:06:11.418Z
        /// </param>
        /// <param name="parameters">
        /// The parameters the job was created with. Import jobs report `display_name`; export jobs report<br/>
        /// `translation_memory_id`.
        /// </param>
        /// <param name="results">
        /// The job's outcome. This array always holds exactly one entry. It is an array so that jobs<br/>
        /// producing multiple outputs can be represented without a breaking change.
        /// </param>
        /// <param name="sourceFile">
        /// The file declared when the import job was created. Omitted for export jobs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryJob(
            global::System.Guid jobId,
            string product,
            global::DeepL.TranslationMemoryJobOperation operation,
            global::System.DateTime creationTime,
            global::System.DateTime updatedTime,
            global::DeepL.TranslationMemoryJobParameters parameters,
            global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryJobResult> results,
            global::DeepL.TranslationMemoryJobSourceFile? sourceFile)
        {
            this.JobId = jobId;
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Operation = operation;
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
            this.SourceFile = sourceFile;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJob" /> class.
        /// </summary>
        public TranslationMemoryJob()
        {
        }

    }
}