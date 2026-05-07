
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// A machine-readable identifier for the error, when available. Clients should match on this value rather than on `message` when branching on error types.<br/>
        /// Example: invalid_content_type
        /// </summary>
        /// <example>invalid_content_type</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
        /// <param name="code">
        /// A machine-readable identifier for the error, when available. Clients should match on this value rather than on `message` when branching on error types.<br/>
        /// Example: invalid_content_type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string message,
            string? code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}