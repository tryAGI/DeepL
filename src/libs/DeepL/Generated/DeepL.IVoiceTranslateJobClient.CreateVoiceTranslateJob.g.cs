#nullable enable

namespace DeepL
{
    public partial interface IVoiceTranslateJobClient
    {
        /// <summary>
        /// Create a voice translation job<br/>
        /// Creates an async voice translation job. The response includes an upload URL for the source audio file.
        /// </summary>
        /// <param name="include"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.VoiceTranslateCreateJobResponse> CreateVoiceTranslateJobAsync(

            global::DeepL.VoiceTranslateCreateJobRequest request,
            global::System.Collections.Generic.IList<global::DeepL.CreateVoiceTranslateJobIncludeItem>? include = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice translation job<br/>
        /// Creates an async voice translation job. The response includes an upload URL for the source audio file.
        /// </summary>
        /// <param name="include"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.VoiceTranslateCreateJobResponse>> CreateVoiceTranslateJobAsResponseAsync(

            global::DeepL.VoiceTranslateCreateJobRequest request,
            global::System.Collections.Generic.IList<global::DeepL.CreateVoiceTranslateJobIncludeItem>? include = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice translation job<br/>
        /// Creates an async voice translation job. The response includes an upload URL for the source audio file.
        /// </summary>
        /// <param name="include"></param>
        /// <param name="sourceFile">
        /// Metadata about the source audio file to be uploaded.
        /// </param>
        /// <param name="parameters">
        /// Processing parameters for the voice translation job.
        /// </param>
        /// <param name="targets">
        /// One or more translation targets. Each target produces a separate result.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.VoiceTranslateCreateJobResponse> CreateVoiceTranslateJobAsync(
            global::DeepL.JobSourceFileRequest sourceFile,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetRequest> targets,
            global::System.Collections.Generic.IList<global::DeepL.CreateVoiceTranslateJobIncludeItem>? include = default,
            global::DeepL.VoiceTranslateJobParametersRequest? parameters = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}