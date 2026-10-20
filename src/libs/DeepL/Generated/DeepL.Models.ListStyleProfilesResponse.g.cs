
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListStyleProfilesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_profiles")]
        public global::System.Collections.Generic.IList<global::DeepL.StyleProfile>? StyleProfiles { get; set; }

        /// <summary>
        /// The total number of style profiles available to the account.<br/>
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
        /// Initializes a new instance of the <see cref="ListStyleProfilesResponse" /> class.
        /// </summary>
        /// <param name="styleProfiles"></param>
        /// <param name="totalCount">
        /// The total number of style profiles available to the account.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListStyleProfilesResponse(
            global::System.Collections.Generic.IList<global::DeepL.StyleProfile>? styleProfiles,
            int? totalCount)
        {
            this.StyleProfiles = styleProfiles;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStyleProfilesResponse" /> class.
        /// </summary>
        public ListStyleProfilesResponse()
        {
        }

    }
}