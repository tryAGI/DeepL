
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLanguagesResponseItem2
    {
        /// <summary>
        /// The language code (BCP 47).<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lang { get; set; }

        /// <summary>
        /// Name of the language in English.<br/>
        /// Example: German
        /// </summary>
        /// <example>German</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this language can be used as a source language with the specified resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usable_as_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UsableAsSource { get; set; }

        /// <summary>
        /// Whether this language can be used as a target language with the specified resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usable_as_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UsableAsTarget { get; set; }

        /// <summary>
        /// Availability status of this language.<br/>
        /// Example: stable
        /// </summary>
        /// <example>stable</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GetLanguagesResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.GetLanguagesResponseItemStatus Status { get; set; }

        /// <summary>
        /// Features supported for this language with the specified resource. Always present;<br/>
        /// empty object if no optional features are supported. Each key is a feature name;<br/>
        /// the value is an object with at least a `status` field. Consult `GET /v3/languages/resources`<br/>
        /// to determine whether a feature must be present on the source language, target language,<br/>
        /// or both for a given resource.<br/>
        /// Example: {"formality":{"status":"stable"},"tag_handling":{"status":"stable"},"glossary":{"status":"stable"}}
        /// </summary>
        /// <example>{"formality":{"status":"stable"},"tag_handling":{"status":"stable"},"glossary":{"status":"stable"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::DeepL.GetLanguagesResponseItemFeatures2> Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguagesResponseItem2" /> class.
        /// </summary>
        /// <param name="lang">
        /// The language code (BCP 47).<br/>
        /// Example: de
        /// </param>
        /// <param name="name">
        /// Name of the language in English.<br/>
        /// Example: German
        /// </param>
        /// <param name="usableAsSource">
        /// Whether this language can be used as a source language with the specified resource.
        /// </param>
        /// <param name="usableAsTarget">
        /// Whether this language can be used as a target language with the specified resource.
        /// </param>
        /// <param name="status">
        /// Availability status of this language.<br/>
        /// Example: stable
        /// </param>
        /// <param name="features">
        /// Features supported for this language with the specified resource. Always present;<br/>
        /// empty object if no optional features are supported. Each key is a feature name;<br/>
        /// the value is an object with at least a `status` field. Consult `GET /v3/languages/resources`<br/>
        /// to determine whether a feature must be present on the source language, target language,<br/>
        /// or both for a given resource.<br/>
        /// Example: {"formality":{"status":"stable"},"tag_handling":{"status":"stable"},"glossary":{"status":"stable"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLanguagesResponseItem2(
            string lang,
            string name,
            bool usableAsSource,
            bool usableAsTarget,
            global::DeepL.GetLanguagesResponseItemStatus status,
            global::System.Collections.Generic.Dictionary<string, global::DeepL.GetLanguagesResponseItemFeatures2> features)
        {
            this.Lang = lang ?? throw new global::System.ArgumentNullException(nameof(lang));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UsableAsSource = usableAsSource;
            this.UsableAsTarget = usableAsTarget;
            this.Status = status;
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguagesResponseItem2" /> class.
        /// </summary>
        public GetLanguagesResponseItem2()
        {
        }

    }
}