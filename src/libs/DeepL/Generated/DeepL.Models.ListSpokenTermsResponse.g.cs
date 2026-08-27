
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListSpokenTermsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spoken_terms")]
        public global::System.Collections.Generic.IList<global::DeepL.SpokenTerms>? SpokenTerms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSpokenTermsResponse" /> class.
        /// </summary>
        /// <param name="spokenTerms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSpokenTermsResponse(
            global::System.Collections.Generic.IList<global::DeepL.SpokenTerms>? spokenTerms)
        {
            this.SpokenTerms = spokenTerms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSpokenTermsResponse" /> class.
        /// </summary>
        public ListSpokenTermsResponse()
        {
        }

    }
}