#nullable enable

namespace DeepL
{
    public partial interface IVoiceTranslateJobClient
    {
        /// <summary>
        /// Get voice translation job status<br/>
        /// Returns the current status of a voice translation job, including per-target result statuses.<br/>
        /// When a target's status is `complete`, the response includes a `download_url` and `signature` for that target. Results are returned in the same order as the targets in the create request.
        /// </summary>
        /// <param name="jobId">
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.VoiceTranslateJobStatusResponse> GetVoiceTranslateJobStatusAsync(
            global::System.Guid jobId,
            global::System.Collections.Generic.IList<global::DeepL.GetVoiceTranslateJobStatusIncludeItem>? include = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get voice translation job status<br/>
        /// Returns the current status of a voice translation job, including per-target result statuses.<br/>
        /// When a target's status is `complete`, the response includes a `download_url` and `signature` for that target. Results are returned in the same order as the targets in the create request.
        /// </summary>
        /// <param name="jobId">
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.VoiceTranslateJobStatusResponse>> GetVoiceTranslateJobStatusAsResponseAsync(
            global::System.Guid jobId,
            global::System.Collections.Generic.IList<global::DeepL.GetVoiceTranslateJobStatusIncludeItem>? include = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}