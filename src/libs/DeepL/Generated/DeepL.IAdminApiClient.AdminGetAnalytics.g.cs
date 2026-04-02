#nullable enable

namespace DeepL
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Get usage statistics as an admin<br/>
        /// Retrieve usage statistics for the organization within a specified date range.<br/>
        /// Optionally group the results by API key or by API key and day.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="groupBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AdminUsageReport> AdminGetAnalyticsAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::DeepL.AdminGetAnalyticsGroupBy? groupBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage statistics as an admin<br/>
        /// Retrieve usage statistics for the organization within a specified date range.<br/>
        /// Optionally group the results by API key or by API key and day.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="groupBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.AdminUsageReport>> AdminGetAnalyticsAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::DeepL.AdminGetAnalyticsGroupBy? groupBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}