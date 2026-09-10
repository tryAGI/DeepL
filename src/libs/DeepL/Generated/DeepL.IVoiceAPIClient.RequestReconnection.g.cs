#nullable enable

namespace DeepL
{
    public partial interface IVoiceAPIClient
    {
        /// <summary>
        /// Request Reconnection<br/>
        /// Exchange a session token for a fresh WebSocket URL and token so a client can rejoin a<br/>
        /// voice session after the connection drops. Session options are carried over from the<br/>
        /// original session.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.VoiceStreamingResponse> RequestReconnectionAsync(
            string token,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Reconnection<br/>
        /// Exchange a session token for a fresh WebSocket URL and token so a client can rejoin a<br/>
        /// voice session after the connection drops. Session options are carried over from the<br/>
        /// original session.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.VoiceStreamingResponse>> RequestReconnectionAsResponseAsync(
            string token,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}