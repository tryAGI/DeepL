
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetMultilingualGlossaryEntriesResponse
    {
        /// <summary>
        /// The dictionaries of the glossary, each with its entries in the requested format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionaries")]
        public global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntries>? Dictionaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultilingualGlossaryEntriesResponse" /> class.
        /// </summary>
        /// <param name="dictionaries">
        /// The dictionaries of the glossary, each with its entries in the requested format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMultilingualGlossaryEntriesResponse(
            global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntries>? dictionaries)
        {
            this.Dictionaries = dictionaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMultilingualGlossaryEntriesResponse" /> class.
        /// </summary>
        public GetMultilingualGlossaryEntriesResponse()
        {
        }

    }
}