
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorrectTextResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvements")]
        public global::System.Collections.Generic.IList<global::DeepL.CorrectTextResponseImprovement>? Improvements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectTextResponse" /> class.
        /// </summary>
        /// <param name="improvements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorrectTextResponse(
            global::System.Collections.Generic.IList<global::DeepL.CorrectTextResponseImprovement>? improvements)
        {
            this.Improvements = improvements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectTextResponse" /> class.
        /// </summary>
        public CorrectTextResponse()
        {
        }

    }
}