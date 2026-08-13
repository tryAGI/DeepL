#nullable enable

namespace DeepL
{
    public partial interface ITranslationMemoriesClient
    {
        /// <summary>
        /// Import a translation memory<br/>
        /// Create a translation memory by importing a TMX file.<br/>
        /// This endpoint does not accept the file itself. It returns a short-lived `upload_url`, and you<br/>
        /// upload the TMX file to that URL with a separate `PUT` request. Processing starts automatically<br/>
        /// once the upload completes, so there is no third call to confirm it.<br/>
        /// 1. `POST /v3/translation_memories/import` with the file's name and size. The response returns a<br/>
        ///    `job_id`, an `upload_url`, and the `expires_at` time after which the URL stops working.<br/>
        /// 2. `PUT` the TMX file to `upload_url`. Do not send your `Authorization` header on this request,<br/>
        ///    because the URL is already signed.<br/>
        /// 3. Poll [Retrieve an import or export job](/api-reference/translation-memory/retrieve-a-translation-memory-job)<br/>
        ///    until the status is `completed`. The new `translation_memory_id` is on the job result.<br/>
        /// Requires an API key with the `translation_memories:write` scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CreateTranslationMemoryImportResponse> CreateTranslationMemoryImportAsync(

            global::DeepL.CreateTranslationMemoryImportRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import a translation memory<br/>
        /// Create a translation memory by importing a TMX file.<br/>
        /// This endpoint does not accept the file itself. It returns a short-lived `upload_url`, and you<br/>
        /// upload the TMX file to that URL with a separate `PUT` request. Processing starts automatically<br/>
        /// once the upload completes, so there is no third call to confirm it.<br/>
        /// 1. `POST /v3/translation_memories/import` with the file's name and size. The response returns a<br/>
        ///    `job_id`, an `upload_url`, and the `expires_at` time after which the URL stops working.<br/>
        /// 2. `PUT` the TMX file to `upload_url`. Do not send your `Authorization` header on this request,<br/>
        ///    because the URL is already signed.<br/>
        /// 3. Poll [Retrieve an import or export job](/api-reference/translation-memory/retrieve-a-translation-memory-job)<br/>
        ///    until the status is `completed`. The new `translation_memory_id` is on the job result.<br/>
        /// Requires an API key with the `translation_memories:write` scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CreateTranslationMemoryImportResponse>> CreateTranslationMemoryImportAsResponseAsync(

            global::DeepL.CreateTranslationMemoryImportRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import a translation memory<br/>
        /// Create a translation memory by importing a TMX file.<br/>
        /// This endpoint does not accept the file itself. It returns a short-lived `upload_url`, and you<br/>
        /// upload the TMX file to that URL with a separate `PUT` request. Processing starts automatically<br/>
        /// once the upload completes, so there is no third call to confirm it.<br/>
        /// 1. `POST /v3/translation_memories/import` with the file's name and size. The response returns a<br/>
        ///    `job_id`, an `upload_url`, and the `expires_at` time after which the URL stops working.<br/>
        /// 2. `PUT` the TMX file to `upload_url`. Do not send your `Authorization` header on this request,<br/>
        ///    because the URL is already signed.<br/>
        /// 3. Poll [Retrieve an import or export job](/api-reference/translation-memory/retrieve-a-translation-memory-job)<br/>
        ///    until the status is `completed`. The new `translation_memory_id` is on the job result.<br/>
        /// Requires an API key with the `translation_memories:write` scope.
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CreateTranslationMemoryImportResponse> CreateTranslationMemoryImportAsync(
            global::DeepL.CreateTranslationMemoryImportRequestSourceFile sourceFile,
            global::DeepL.CreateTranslationMemoryImportRequestParameters? parameters = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}