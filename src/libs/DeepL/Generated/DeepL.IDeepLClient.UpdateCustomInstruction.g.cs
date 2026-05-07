#nullable enable

namespace DeepL
{
    public partial interface IDeepLClient
    {
        /// <summary>
        /// Replace a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CustomInstruction> UpdateCustomInstructionAsync(
            string styleId,
            string instructionId,

            global::DeepL.UpdateCustomInstructionRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CustomInstruction>> UpdateCustomInstructionAsResponseAsync(
            string styleId,
            string instructionId,

            global::DeepL.UpdateCustomInstructionRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="label">
        /// Updated label for the custom instruction
        /// </param>
        /// <param name="prompt">
        /// Updated instruction text
        /// </param>
        /// <param name="sourceLanguage">
        /// Optional source language code
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CustomInstruction> UpdateCustomInstructionAsync(
            string styleId,
            string instructionId,
            string label,
            string prompt,
            string? sourceLanguage = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}