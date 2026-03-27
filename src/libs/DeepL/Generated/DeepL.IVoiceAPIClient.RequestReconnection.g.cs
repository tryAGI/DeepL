#nullable enable

namespace DeepL
{
    public partial interface IVoiceAPIClient
    {
        /// <summary>
        /// Request Reconnection
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.VoiceStreamingResponse> RequestReconnectionAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}