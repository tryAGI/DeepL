#nullable enable

namespace DeepL
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Get custom tag usage statistics as an admin<br/>
        /// Retrieve usage statistics broken down by custom tags within a specified date range.<br/>
        /// Optionally aggregate results by day or over the entire period.<br/>
        /// Results are paginated; use the `page` parameter with the `next_page` value from<br/>
        /// a previous response to retrieve subsequent pages.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="aggregateBy">
        /// Default Value: period
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CustomTagUsageReport> AdminGetCustomTagAnalyticsAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::DeepL.AdminGetCustomTagAnalyticsAggregateBy? aggregateBy = default,
            int? page = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get custom tag usage statistics as an admin<br/>
        /// Retrieve usage statistics broken down by custom tags within a specified date range.<br/>
        /// Optionally aggregate results by day or over the entire period.<br/>
        /// Results are paginated; use the `page` parameter with the `next_page` value from<br/>
        /// a previous response to retrieve subsequent pages.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="aggregateBy">
        /// Default Value: period
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CustomTagUsageReport>> AdminGetCustomTagAnalyticsAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::DeepL.AdminGetCustomTagAnalyticsAggregateBy? aggregateBy = default,
            int? page = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}