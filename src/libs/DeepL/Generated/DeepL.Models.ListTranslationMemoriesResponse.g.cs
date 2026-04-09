
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTranslationMemoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memories")]
        public global::System.Collections.Generic.IList<global::DeepL.TranslationMemory>? TranslationMemories { get; set; }

        /// <summary>
        /// The total number of translation memories available.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranslationMemoriesResponse" /> class.
        /// </summary>
        /// <param name="translationMemories"></param>
        /// <param name="totalCount">
        /// The total number of translation memories available.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTranslationMemoriesResponse(
            global::System.Collections.Generic.IList<global::DeepL.TranslationMemory>? translationMemories,
            int? totalCount)
        {
            this.TranslationMemories = translationMemories;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranslationMemoriesResponse" /> class.
        /// </summary>
        public ListTranslationMemoriesResponse()
        {
        }
    }
}