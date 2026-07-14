
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpokenTermsParameters
    {
        /// <summary>
        /// Name for the Spoken Terms collection.<br/>
        /// Example: Technical Terms
        /// </summary>
        /// <example>Technical Terms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Array of term lists, one per language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term_lists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput> TermLists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpokenTermsParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the Spoken Terms collection.<br/>
        /// Example: Technical Terms
        /// </param>
        /// <param name="termLists">
        /// Array of term lists, one per language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpokenTermsParameters(
            string name,
            global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput> termLists)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TermLists = termLists ?? throw new global::System.ArgumentNullException(nameof(termLists));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpokenTermsParameters" /> class.
        /// </summary>
        public CreateSpokenTermsParameters()
        {
        }

    }
}