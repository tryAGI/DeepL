
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCustomInstructionRequest
    {
        /// <summary>
        /// Label for the custom instruction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Instruction text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional source language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomInstructionRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// Label for the custom instruction
        /// </param>
        /// <param name="prompt">
        /// Instruction text
        /// </param>
        /// <param name="sourceLanguage">
        /// Optional source language code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCustomInstructionRequest(
            string label,
            string prompt,
            string? sourceLanguage)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SourceLanguage = sourceLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomInstructionRequest" /> class.
        /// </summary>
        public CreateCustomInstructionRequest()
        {
        }

    }
}