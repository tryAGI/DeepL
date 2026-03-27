
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Contains the detailed usage statistics for the specified date range.
    /// </summary>
    public sealed partial class AdminUsageReportData
    {
        /// <summary>
        /// Breakdown of character usage by category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_usage")]
        public global::DeepL.UsageBreakdown? TotalUsage { get; set; }

        /// <summary>
        /// Start date of the usage report period.<br/>
        /// Example: 2025-09-29T00:00:00
        /// </summary>
        /// <example>2025-09-29T00:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of the usage report period.<br/>
        /// Example: 2025-10-01T00:00:00
        /// </summary>
        /// <example>2025-10-01T00:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The grouping method used, if any.<br/>
        /// Example: key_and_day
        /// </summary>
        /// <example>key_and_day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.AdminUsageReportDataGroupByJsonConverter))]
        public global::DeepL.AdminUsageReportDataGroupBy? GroupBy { get; set; }

        /// <summary>
        /// Usage statistics grouped by key. Present when group_by='key'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_usages")]
        public global::System.Collections.Generic.IList<global::DeepL.KeyUsageItem>? KeyUsages { get; set; }

        /// <summary>
        /// Usage statistics grouped by key and day. Present when group_by='key_and_day'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_and_day_usages")]
        public global::System.Collections.Generic.IList<global::DeepL.KeyAndDayUsageItem>? KeyAndDayUsages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsageReportData" /> class.
        /// </summary>
        /// <param name="totalUsage">
        /// Breakdown of character usage by category.
        /// </param>
        /// <param name="startDate">
        /// Start date of the usage report period.<br/>
        /// Example: 2025-09-29T00:00:00
        /// </param>
        /// <param name="endDate">
        /// End date of the usage report period.<br/>
        /// Example: 2025-10-01T00:00:00
        /// </param>
        /// <param name="groupBy">
        /// The grouping method used, if any.<br/>
        /// Example: key_and_day
        /// </param>
        /// <param name="keyUsages">
        /// Usage statistics grouped by key. Present when group_by='key'.
        /// </param>
        /// <param name="keyAndDayUsages">
        /// Usage statistics grouped by key and day. Present when group_by='key_and_day'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminUsageReportData(
            global::DeepL.UsageBreakdown? totalUsage,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::DeepL.AdminUsageReportDataGroupBy? groupBy,
            global::System.Collections.Generic.IList<global::DeepL.KeyUsageItem>? keyUsages,
            global::System.Collections.Generic.IList<global::DeepL.KeyAndDayUsageItem>? keyAndDayUsages)
        {
            this.TotalUsage = totalUsage;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GroupBy = groupBy;
            this.KeyUsages = keyUsages;
            this.KeyAndDayUsages = keyAndDayUsages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsageReportData" /> class.
        /// </summary>
        public AdminUsageReportData()
        {
        }
    }
}