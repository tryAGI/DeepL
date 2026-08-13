
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationMemoryImportRequestParameters
    {
        /// <summary>
        /// The name to give the new translation memory. If you omit this, the translation memory<br/>
        /// is created without a name.<br/>
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
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportRequestParameters" /> class.
        /// </summary>
        /// <param name="displayName">
        /// The name to give the new translation memory. If you omit this, the translation memory<br/>
        /// is created without a name.<br/>
        /// Example: Legal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslationMemoryImportRequestParameters(
            string? displayName)
        {
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportRequestParameters" /> class.
        /// </summary>
        public CreateTranslationMemoryImportRequestParameters()
        {
        }

    }
}