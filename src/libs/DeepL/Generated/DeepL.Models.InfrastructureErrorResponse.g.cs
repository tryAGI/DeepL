
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Error body returned by DeepL's edge infrastructure for failures that occur before a request reaches the API itself. The message is nested under `error`, unlike the application-level `ErrorResponse`. Clients that parse error bodies should handle both shapes.
    /// </summary>
    public sealed partial class InfrastructureErrorResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.InfrastructureErrorResponseError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureErrorResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfrastructureErrorResponse(
            global::DeepL.InfrastructureErrorResponseError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureErrorResponse" /> class.
        /// </summary>
        public InfrastructureErrorResponse()
        {
        }

    }
}