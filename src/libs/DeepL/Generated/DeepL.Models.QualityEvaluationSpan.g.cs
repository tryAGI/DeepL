
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A half-open `[start, end)` range of Unicode code points within a segment's source or target text. See [About span ranges](/api-reference/quality-evaluation/poll#about-span-ranges).
    /// </summary>
    public sealed partial class QualityEvaluationSpan
    {
        /// <summary>
        /// Inclusive start index. A 0-based Unicode code-point offset.<br/>
        /// Example: 23
        /// </summary>
        /// <example>23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// Exclusive end index. A 0-based Unicode code-point offset.<br/>
        /// Example: 31
        /// </summary>
        /// <example>31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationSpan" /> class.
        /// </summary>
        /// <param name="start">
        /// Inclusive start index. A 0-based Unicode code-point offset.<br/>
        /// Example: 23
        /// </param>
        /// <param name="end">
        /// Exclusive end index. A 0-based Unicode code-point offset.<br/>
        /// Example: 31
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationSpan(
            int start,
            int end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationSpan" /> class.
        /// </summary>
        public QualityEvaluationSpan()
        {
        }

    }
}