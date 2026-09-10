
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfrastructureErrorResponseError
    {
        /// <summary>
        /// A human-readable description of the error.<br/>
        /// Example: Bad Gateway.
        /// </summary>
        /// <example>Bad Gateway.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureErrorResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the error.<br/>
        /// Example: Bad Gateway.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfrastructureErrorResponseError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureErrorResponseError" /> class.
        /// </summary>
        public InfrastructureErrorResponseError()
        {
        }

    }
}