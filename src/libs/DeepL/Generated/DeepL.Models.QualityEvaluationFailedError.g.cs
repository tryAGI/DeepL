
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationFailedError
    {
        /// <summary>
        /// Machine-readable error code. Currently always `evaluation_failed`.<br/>
        /// Example: evaluation_failed
        /// </summary>
        /// <example>evaluation_failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Error message.<br/>
        /// Example: The evaluation pipeline encountered an unexpected error.
        /// </summary>
        /// <example>The evaluation pipeline encountered an unexpected error.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationFailedError" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code. Currently always `evaluation_failed`.<br/>
        /// Example: evaluation_failed
        /// </param>
        /// <param name="message">
        /// Error message.<br/>
        /// Example: The evaluation pipeline encountered an unexpected error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationFailedError(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationFailedError" /> class.
        /// </summary>
        public QualityEvaluationFailedError()
        {
        }

    }
}