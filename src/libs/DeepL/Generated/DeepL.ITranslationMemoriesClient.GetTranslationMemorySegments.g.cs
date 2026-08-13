#nullable enable

namespace DeepL
{
    public partial interface ITranslationMemoriesClient
    {
        /// <summary>
        /// List translation memory segments<br/>
        /// List the segments stored in a translation memory, one page at a time. Each entry is a source<br/>
        /// segment with its translations in every target language.<br/>
        /// This endpoint uses cursor-based pagination rather than the numbered pages used by<br/>
        /// [List translation memories](/api-reference/translation-memory/list-translation-memories). Omit<br/>
        /// `page_cursor` on your first call, then pass the `next_page_cursor` from each response to get the<br/>
        /// following page. When a response has no `next_page_cursor`, you have reached the last page.<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="pageCursor"></param>
        /// <param name="filterText"></param>
        /// <param name="filterCaseSensitive">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.GetTranslationMemorySegmentsResponse> GetTranslationMemorySegmentsAsync(
            global::System.Guid translationMemoryId,
            int? pageSize = default,
            string? pageCursor = default,
            string? filterText = default,
            bool? filterCaseSensitive = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List translation memory segments<br/>
        /// List the segments stored in a translation memory, one page at a time. Each entry is a source<br/>
        /// segment with its translations in every target language.<br/>
        /// This endpoint uses cursor-based pagination rather than the numbered pages used by<br/>
        /// [List translation memories](/api-reference/translation-memory/list-translation-memories). Omit<br/>
        /// `page_cursor` on your first call, then pass the `next_page_cursor` from each response to get the<br/>
        /// following page. When a response has no `next_page_cursor`, you have reached the last page.<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="pageCursor"></param>
        /// <param name="filterText"></param>
        /// <param name="filterCaseSensitive">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.GetTranslationMemorySegmentsResponse>> GetTranslationMemorySegmentsAsResponseAsync(
            global::System.Guid translationMemoryId,
            int? pageSize = default,
            string? pageCursor = default,
            string? filterText = default,
            bool? filterCaseSensitive = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}