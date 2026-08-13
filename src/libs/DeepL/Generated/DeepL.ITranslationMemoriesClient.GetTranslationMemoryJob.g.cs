#nullable enable

namespace DeepL
{
    public partial interface ITranslationMemoriesClient
    {
        /// <summary>
        /// Retrieve an import or export job<br/>
        /// Retrieve the status of a translation memory import or export job.<br/>
        /// Poll this endpoint after creating a job. The `operation` field tells you which kind of job it is,<br/>
        /// and the single entry in `results` carries the status and, once the job finishes, its output: the<br/>
        /// new `translation_memory_id` for an import, or a `download_url` for an export.<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslationMemoryJob> GetTranslationMemoryJobAsync(
            global::System.Guid jobId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve an import or export job<br/>
        /// Retrieve the status of a translation memory import or export job.<br/>
        /// Poll this endpoint after creating a job. The `operation` field tells you which kind of job it is,<br/>
        /// and the single entry in `results` carries the status and, once the job finishes, its output: the<br/>
        /// new `translation_memory_id` for an import, or a `download_url` for an export.<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslationMemoryJob>> GetTranslationMemoryJobAsResponseAsync(
            global::System.Guid jobId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}