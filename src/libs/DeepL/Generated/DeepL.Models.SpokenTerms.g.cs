
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpokenTerms
    {
        /// <summary>
        /// A unique ID assigned to the Spoken Terms collection.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spoken_terms_id")]
        public string? SpokenTermsId { get; set; }

        /// <summary>
        /// Name of the Spoken Terms collection.<br/>
        /// Example: Technical Terms
        /// </summary>
        /// <example>Technical Terms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of term lists contained in this collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term_lists")]
        public global::System.Collections.Generic.IList<global::DeepL.SpokenTermsList>? TermLists { get; set; }

        /// <summary>
        /// The creation time of the Spoken Terms collection in ISO 8601-1:2019 format (e.g.: `2025-08-03T14:16:18.329Z`).<br/>
        /// Example: 2025-08-03T14:16:18.329Z
        /// </summary>
        /// <example>2025-08-03T14:16:18.329Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTerms" /> class.
        /// </summary>
        /// <param name="spokenTermsId">
        /// A unique ID assigned to the Spoken Terms collection.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="name">
        /// Name of the Spoken Terms collection.<br/>
        /// Example: Technical Terms
        /// </param>
        /// <param name="termLists">
        /// List of term lists contained in this collection.
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the Spoken Terms collection in ISO 8601-1:2019 format (e.g.: `2025-08-03T14:16:18.329Z`).<br/>
        /// Example: 2025-08-03T14:16:18.329Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpokenTerms(
            string? spokenTermsId,
            string? name,
            global::System.Collections.Generic.IList<global::DeepL.SpokenTermsList>? termLists,
            global::System.DateTime? creationTime)
        {
            this.SpokenTermsId = spokenTermsId;
            this.Name = name;
            this.TermLists = termLists;
            this.CreationTime = creationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTerms" /> class.
        /// </summary>
        public SpokenTerms()
        {
        }

    }
}