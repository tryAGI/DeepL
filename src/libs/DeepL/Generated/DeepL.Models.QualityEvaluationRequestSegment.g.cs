
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationRequestSegment
    {
        /// <summary>
        /// The original text in the source language.<br/>
        /// Example: Our Q3 revenue came in 5% above forecast.
        /// </summary>
        /// <example>Our Q3 revenue came in 5% above forecast.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The translated text in the target language.<br/>
        /// Example: Unser Q3-Umsatz lag 5 % unter der Prognose.
        /// </summary>
        /// <example>Unser Q3-Umsatz lag 5 % unter der Prognose.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationRequestSegment" /> class.
        /// </summary>
        /// <param name="source">
        /// The original text in the source language.<br/>
        /// Example: Our Q3 revenue came in 5% above forecast.
        /// </param>
        /// <param name="target">
        /// The translated text in the target language.<br/>
        /// Example: Unser Q3-Umsatz lag 5 % unter der Prognose.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationRequestSegment(
            string source,
            string target)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationRequestSegment" /> class.
        /// </summary>
        public QualityEvaluationRequestSegment()
        {
        }

    }
}