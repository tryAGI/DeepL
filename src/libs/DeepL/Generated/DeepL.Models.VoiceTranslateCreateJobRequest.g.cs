
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceTranslateCreateJobRequest
    {
        /// <summary>
        /// Metadata about the source audio file to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.JobSourceFileRequest SourceFile { get; set; }

        /// <summary>
        /// Processing parameters for the voice translation job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::DeepL.VoiceTranslateJobParametersRequest? Parameters { get; set; }

        /// <summary>
        /// One or more translation targets. Each target produces a separate result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetRequest> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateCreateJobRequest" /> class.
        /// </summary>
        /// <param name="sourceFile">
        /// Metadata about the source audio file to be uploaded.
        /// </param>
        /// <param name="targets">
        /// One or more translation targets. Each target produces a separate result.
        /// </param>
        /// <param name="parameters">
        /// Processing parameters for the voice translation job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceTranslateCreateJobRequest(
            global::DeepL.JobSourceFileRequest sourceFile,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetRequest> targets,
            global::DeepL.VoiceTranslateJobParametersRequest? parameters)
        {
            this.SourceFile = sourceFile ?? throw new global::System.ArgumentNullException(nameof(sourceFile));
            this.Parameters = parameters;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateCreateJobRequest" /> class.
        /// </summary>
        public VoiceTranslateCreateJobRequest()
        {
        }

    }
}