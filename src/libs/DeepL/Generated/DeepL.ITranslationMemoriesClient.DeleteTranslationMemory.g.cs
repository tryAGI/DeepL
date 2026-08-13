#nullable enable

namespace DeepL
{
    public partial interface ITranslationMemoriesClient
    {
        /// <summary>
        /// Delete a translation memory<br/>
        /// Delete a translation memory and all of its segments.<br/>
        /// Deletion is permanent and cannot be undone. Export the translation memory first if you need a<br/>
        /// copy of its contents. Translation requests that pass the deleted `translation_memory_id` fail<br/>
        /// after this call, so update your integration before deleting.<br/>
        /// Requires an API key with the `translation_memories:write` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTranslationMemoryAsync(
            global::System.Guid translationMemoryId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a translation memory<br/>
        /// Delete a translation memory and all of its segments.<br/>
        /// Deletion is permanent and cannot be undone. Export the translation memory first if you need a<br/>
        /// copy of its contents. Translation requests that pass the deleted `translation_memory_id` fail<br/>
        /// after this call, so update your integration before deleting.<br/>
        /// Requires an API key with the `translation_memories:write` scope.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse> DeleteTranslationMemoryAsResponseAsync(
            global::System.Guid translationMemoryId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}