#nullable enable

namespace DeepL
{
    public partial interface IDeepLClient
    {
        /// <summary>
        /// Create a custom instruction<br/>
        /// Add a custom instruction to a style rule list to express a style preference that the<br/>
        /// predefined rules do not cover. Instructions apply to text in the given source language.
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CustomInstruction> CreateCustomInstructionAsync(
            string styleId,

            global::DeepL.CreateCustomInstructionRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom instruction<br/>
        /// Add a custom instruction to a style rule list to express a style preference that the<br/>
        /// predefined rules do not cover. Instructions apply to text in the given source language.
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CustomInstruction>> CreateCustomInstructionAsResponseAsync(
            string styleId,

            global::DeepL.CreateCustomInstructionRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom instruction<br/>
        /// Add a custom instruction to a style rule list to express a style preference that the<br/>
        /// predefined rules do not cover. Instructions apply to text in the given source language.
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="label">
        /// Label for the custom instruction
        /// </param>
        /// <param name="prompt">
        /// Instruction text
        /// </param>
        /// <param name="sourceLanguage">
        /// Optional source language code
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CustomInstruction> CreateCustomInstructionAsync(
            string styleId,
            string label,
            string prompt,
            string? sourceLanguage = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}