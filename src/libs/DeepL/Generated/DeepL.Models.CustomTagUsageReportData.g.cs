
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Contains the detailed custom tag usage statistics for the specified date range.
    /// </summary>
    public sealed partial class CustomTagUsageReportData
    {
        /// <summary>
        /// The aggregation method used.<br/>
        /// Example: period
        /// </summary>
        /// <example>period</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.CustomTagUsageReportDataAggregateByJsonConverter))]
        public global::DeepL.CustomTagUsageReportDataAggregateBy? AggregateBy { get; set; }

        /// <summary>
        /// Start date of the usage report period.<br/>
        /// Example: 2026-05-03T00:00:00
        /// </summary>
        /// <example>2026-05-03T00:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of the usage report period.<br/>
        /// Example: 2026-05-05T00:00:00
        /// </summary>
        /// <example>2026-05-05T00:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Cursor for the next page of results. Null if there are no further pages.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public int? NextPage { get; set; }

        /// <summary>
        /// List of custom tag usage entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::System.Collections.Generic.IList<global::DeepL.CustomTagUsageItem>? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagUsageReportData" /> class.
        /// </summary>
        /// <param name="aggregateBy">
        /// The aggregation method used.<br/>
        /// Example: period
        /// </param>
        /// <param name="startDate">
        /// Start date of the usage report period.<br/>
        /// Example: 2026-05-03T00:00:00
        /// </param>
        /// <param name="endDate">
        /// End date of the usage report period.<br/>
        /// Example: 2026-05-05T00:00:00
        /// </param>
        /// <param name="nextPage">
        /// Cursor for the next page of results. Null if there are no further pages.<br/>
        /// Example: 2
        /// </param>
        /// <param name="usage">
        /// List of custom tag usage entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTagUsageReportData(
            global::DeepL.CustomTagUsageReportDataAggregateBy? aggregateBy,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            int? nextPage,
            global::System.Collections.Generic.IList<global::DeepL.CustomTagUsageItem>? usage)
        {
            this.AggregateBy = aggregateBy;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.NextPage = nextPage;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagUsageReportData" /> class.
        /// </summary>
        public CustomTagUsageReportData()
        {
        }

    }
}