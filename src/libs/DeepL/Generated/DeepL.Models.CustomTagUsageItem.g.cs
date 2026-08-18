
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Usage statistics for a specific custom tag.
    /// </summary>
    public sealed partial class CustomTagUsageItem
    {
        /// <summary>
        /// The custom tag identifier.<br/>
        /// Example: example-custom-tag
        /// </summary>
        /// <example>example-custom-tag</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tag")]
        public string? CustomTag { get; set; }

        /// <summary>
        /// The day the usage was recorded. Only returned when `aggregate_by` is `day`.<br/>
        /// Example: 2026-05-04T00:00:00Z
        /// </summary>
        /// <example>2026-05-04T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_date")]
        public global::System.DateTime? UsageDate { get; set; }

        /// <summary>
        /// Breakdown of usage by category for a custom tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::DeepL.CustomTagBreakdown? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagUsageItem" /> class.
        /// </summary>
        /// <param name="customTag">
        /// The custom tag identifier.<br/>
        /// Example: example-custom-tag
        /// </param>
        /// <param name="usageDate">
        /// The day the usage was recorded. Only returned when `aggregate_by` is `day`.<br/>
        /// Example: 2026-05-04T00:00:00Z
        /// </param>
        /// <param name="breakdown">
        /// Breakdown of usage by category for a custom tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTagUsageItem(
            string? customTag,
            global::System.DateTime? usageDate,
            global::DeepL.CustomTagBreakdown? breakdown)
        {
            this.CustomTag = customTag;
            this.UsageDate = usageDate;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagUsageItem" /> class.
        /// </summary>
        public CustomTagUsageItem()
        {
        }

    }
}