#nullable enable

namespace DeepL
{
    public partial interface ITranslateDocumentsClient
    {
        /// <summary>
        /// Download Translated Document<br/>
        /// Download a translated document. The document must have a status of `done`. Each<br/>
        /// document can be downloaded only once: after a successful download DeepL deletes the<br/>
        /// file and invalidates the `document_id`.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadDocumentAsync(
            string documentId,

            global::DeepL.DocumentKey request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Translated Document<br/>
        /// Download a translated document. The document must have a status of `done`. Each<br/>
        /// document can be downloaded only once: after a successful download DeepL deletes the<br/>
        /// file and invalidates the `document_id`.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DownloadDocumentAsStreamAsync(
            string documentId,

            global::DeepL.DocumentKey request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Translated Document<br/>
        /// Download a translated document. The document must have a status of `done`. Each<br/>
        /// document can be downloaded only once: after a successful download DeepL deletes the<br/>
        /// file and invalidates the `document_id`.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<byte[]>> DownloadDocumentAsResponseAsync(
            string documentId,

            global::DeepL.DocumentKey request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Translated Document<br/>
        /// Download a translated document. The document must have a status of `done`. Each<br/>
        /// document can be downloaded only once: after a successful download DeepL deletes the<br/>
        /// file and invalidates the `document_id`.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentKey1">
        /// The document encryption key that was sent to the client when the document was uploaded to the API.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadDocumentAsync(
            string documentId,
            string documentKey1,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}