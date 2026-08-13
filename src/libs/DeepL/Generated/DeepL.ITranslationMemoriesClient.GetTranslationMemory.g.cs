#nullable enable

namespace DeepL
{
    public partial interface ITranslationMemoriesClient
    {
        /// <summary>
        /// Retrieve a translation memory<br/>
        /// Retrieve a single translation memory by its ID, including its languages and segment count.<br/>
        /// To read the stored segments themselves, use<br/>
        /// [List translation memory segments](/api-reference/translation-memory/list-translation-memory-segments).<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslationMemory> GetTranslationMemoryAsync(
            global::System.Guid translationMemoryId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a translation memory<br/>
        /// Retrieve a single translation memory by its ID, including its languages and segment count.<br/>
        /// To read the stored segments themselves, use<br/>
        /// [List translation memory segments](/api-reference/translation-memory/list-translation-memory-segments).<br/>
        /// Requires an API key with the `translation_memories:read` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslationMemory>> GetTranslationMemoryAsResponseAsync(
            global::System.Guid translationMemoryId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}