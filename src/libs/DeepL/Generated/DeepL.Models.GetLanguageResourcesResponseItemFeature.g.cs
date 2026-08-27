
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetLanguageResourcesResponseItemFeature
    {
        /// <summary>
        /// The feature identifier, corresponding to keys in the `features` object returned by `GET /v3/languages`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GetLanguageResourcesResponseItemFeatureNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.GetLanguageResourcesResponseItemFeatureName Name { get; set; }

        /// <summary>
        /// If `true`, the source language must support this feature for it to be available. Defaults to `false` if absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("needs_source_support")]
        public bool? NeedsSourceSupport { get; set; }

        /// <summary>
        /// If `true`, the target language must support this feature for it to be available. Defaults to `false` if absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("needs_target_support")]
        public bool? NeedsTargetSupport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguageResourcesResponseItemFeature" /> class.
        /// </summary>
        /// <param name="name">
        /// The feature identifier, corresponding to keys in the `features` object returned by `GET /v3/languages`.
        /// </param>
        /// <param name="needsSourceSupport">
        /// If `true`, the source language must support this feature for it to be available. Defaults to `false` if absent.
        /// </param>
        /// <param name="needsTargetSupport">
        /// If `true`, the target language must support this feature for it to be available. Defaults to `false` if absent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLanguageResourcesResponseItemFeature(
            global::DeepL.GetLanguageResourcesResponseItemFeatureName name,
            bool? needsSourceSupport,
            bool? needsTargetSupport)
        {
            this.Name = name;
            this.NeedsSourceSupport = needsSourceSupport;
            this.NeedsTargetSupport = needsTargetSupport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguageResourcesResponseItemFeature" /> class.
        /// </summary>
        public GetLanguageResourcesResponseItemFeature()
        {
        }

    }
}