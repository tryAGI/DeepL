#nullable enable

namespace DeepL
{
    public partial interface ITranslationMemoriesClient
    {
        /// <summary>
        /// Export a translation memory<br/>
        /// Export a translation memory as a TMX file.<br/>
        /// The export runs as a background job. Poll<br/>
        /// [Retrieve an import or export job](/api-reference/translation-memory/retrieve-a-translation-memory-job)<br/>
        /// until the status is `completed`, then download the file from the `download_url` on the job result.<br/>
        /// That URL is short-lived, so download the file rather than storing the link.<br/>
        /// If a recent export of the same translation memory is still available, DeepL reuses it and returns<br/>
        /// `200 OK` with that job instead of starting a new one. Handle both `200` and `202` as success. If a<br/>
        /// different export of the same translation memory is still running, the request returns<br/>
        /// `409 Conflict`.<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CreateTranslationMemoryExport> CreateTranslationMemoryExportAsync(
            global::System.Guid translationMemoryId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export a translation memory<br/>
        /// Export a translation memory as a TMX file.<br/>
        /// The export runs as a background job. Poll<br/>
        /// [Retrieve an import or export job](/api-reference/translation-memory/retrieve-a-translation-memory-job)<br/>
        /// until the status is `completed`, then download the file from the `download_url` on the job result.<br/>
        /// That URL is short-lived, so download the file rather than storing the link.<br/>
        /// If a recent export of the same translation memory is still available, DeepL reuses it and returns<br/>
        /// `200 OK` with that job instead of starting a new one. Handle both `200` and `202` as success. If a<br/>
        /// different export of the same translation memory is still running, the request returns<br/>
        /// `409 Conflict`.<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CreateTranslationMemoryExport>> CreateTranslationMemoryExportAsResponseAsync(
            global::System.Guid translationMemoryId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}