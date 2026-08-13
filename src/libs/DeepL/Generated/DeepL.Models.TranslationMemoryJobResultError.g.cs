
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Why the job failed. Present only when `status` is `failed`.
    /// </summary>
    public sealed partial class TranslationMemoryJobResultError
    {
        /// <summary>
        /// A description of the failure.<br/>
        /// Example: The uploaded file is not valid TMX.
        /// </summary>
        /// <example>The uploaded file is not valid TMX.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobResultError" /> class.
        /// </summary>
        /// <param name="message">
        /// A description of the failure.<br/>
        /// Example: The uploaded file is not valid TMX.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryJobResultError(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobResultError" /> class.
        /// </summary>
        public TranslationMemoryJobResultError()
        {
        }

    }
}