
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The parameters the job was created with. Import jobs report `display_name`; export jobs report<br/>
    /// `translation_memory_id`.
    /// </summary>
    public sealed partial class TranslationMemoryJobParameters
    {
        /// <summary>
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </summary>
        /// <example>a74d88fb-ed2a-4943-a664-a4512398b994</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_id")]
        public global::System.Guid? TranslationMemoryId { get; set; }

        /// <summary>
        /// The name given to the translation memory the import creates.<br/>
        /// Example: Legal
        /// </summary>
        /// <example>Legal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobParameters" /> class.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="displayName">
        /// The name given to the translation memory the import creates.<br/>
        /// Example: Legal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryJobParameters(
            global::System.Guid? translationMemoryId,
            string? displayName)
        {
            this.TranslationMemoryId = translationMemoryId;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobParameters" /> class.
        /// </summary>
        public TranslationMemoryJobParameters()
        {
        }

    }
}