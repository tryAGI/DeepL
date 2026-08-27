
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchSpokenTermsParameters
    {
        /// <summary>
        /// New name for the Spoken Terms collection.<br/>
        /// Example: Updated Technical Terms
        /// </summary>
        /// <example>Updated Technical Terms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Term lists to merge with existing lists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term_lists")]
        public global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput>? TermLists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSpokenTermsParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the Spoken Terms collection.<br/>
        /// Example: Updated Technical Terms
        /// </param>
        /// <param name="termLists">
        /// Term lists to merge with existing lists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchSpokenTermsParameters(
            string? name,
            global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput>? termLists)
        {
            this.Name = name;
            this.TermLists = termLists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSpokenTermsParameters" /> class.
        /// </summary>
        public PatchSpokenTermsParameters()
        {
        }

    }
}