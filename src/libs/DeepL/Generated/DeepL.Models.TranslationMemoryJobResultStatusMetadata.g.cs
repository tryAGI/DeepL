
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Extra context for states that need you to act. Present only when there is something to do.
    /// </summary>
    public sealed partial class TranslationMemoryJobResultStatusMetadata
    {
        /// <summary>
        /// What the job is waiting for.<br/>
        /// Example: Waiting for upload
        /// </summary>
        /// <example>Waiting for upload</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_action")]
        public string? RequiredAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobResultStatusMetadata" /> class.
        /// </summary>
        /// <param name="requiredAction">
        /// What the job is waiting for.<br/>
        /// Example: Waiting for upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryJobResultStatusMetadata(
            string? requiredAction)
        {
            this.RequiredAction = requiredAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobResultStatusMetadata" /> class.
        /// </summary>
        public TranslationMemoryJobResultStatusMetadata()
        {
        }

    }
}