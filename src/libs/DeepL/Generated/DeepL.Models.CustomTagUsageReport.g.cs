
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The response for admin custom tag usage statistics.
    /// </summary>
    public sealed partial class CustomTagUsageReport
    {
        /// <summary>
        /// Contains the detailed custom tag usage statistics for the specified date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tag_usage_report")]
        public global::DeepL.CustomTagUsageReportData? CustomTagUsageReport1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagUsageReport" /> class.
        /// </summary>
        /// <param name="customTagUsageReport1">
        /// Contains the detailed custom tag usage statistics for the specified date range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTagUsageReport(
            global::DeepL.CustomTagUsageReportData? customTagUsageReport1)
        {
            this.CustomTagUsageReport1 = customTagUsageReport1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagUsageReport" /> class.
        /// </summary>
        public CustomTagUsageReport()
        {
        }

    }
}