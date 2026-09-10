#nullable enable

namespace DeepL
{
    public partial interface IMetaInformationClient
    {
        /// <summary>
        /// Check Usage and Limits<br/>
        /// Retrieve character and minute usage for the current billing period together with the<br/>
        /// corresponding account limits. Poll this endpoint to track consumption and detect when<br/>
        /// an account is approaching its quota.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.UsageResponse> GetUsageAsync(
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Usage and Limits<br/>
        /// Retrieve character and minute usage for the current billing period together with the<br/>
        /// corresponding account limits. Poll this endpoint to track consumption and detect when<br/>
        /// an account is approaching its quota.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.UsageResponse>> GetUsageAsResponseAsync(
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}