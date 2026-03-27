
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultilingualGlossaryEntriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionaries")]
        public global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntriesInformation>? Dictionaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesResponse" /> class.
        /// </summary>
        /// <param name="dictionaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultilingualGlossaryEntriesResponse(
            global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntriesInformation>? dictionaries)
        {
            this.Dictionaries = dictionaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesResponse" /> class.
        /// </summary>
        public MultilingualGlossaryEntriesResponse()
        {
        }
    }
}