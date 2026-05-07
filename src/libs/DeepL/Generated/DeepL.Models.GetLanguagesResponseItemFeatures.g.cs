
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Features supported for this language with the specified resource. Always present;<br/>
    /// empty object if no optional features are supported. Each key is a feature name;<br/>
    /// the value is an object with at least a `status` field. Consult `GET /v3/languages/resources`<br/>
    /// to determine whether a feature must be present on the source language, target language,<br/>
    /// or both for a given resource.<br/>
    /// Example: {"formality":{"status":"stable"},"tag_handling":{"status":"stable"},"glossary":{"status":"stable"}}
    /// </summary>
    public sealed partial class GetLanguagesResponseItemFeatures
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}