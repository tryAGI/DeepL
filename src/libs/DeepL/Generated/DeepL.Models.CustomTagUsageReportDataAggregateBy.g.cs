
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The aggregation method used.<br/>
    /// Example: period
    /// </summary>
    public enum CustomTagUsageReportDataAggregateBy
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Period,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomTagUsageReportDataAggregateByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomTagUsageReportDataAggregateBy value)
        {
            return value switch
            {
                CustomTagUsageReportDataAggregateBy.Day => "day",
                CustomTagUsageReportDataAggregateBy.Period => "period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomTagUsageReportDataAggregateBy? ToEnum(string value)
        {
            return value switch
            {
                "day" => CustomTagUsageReportDataAggregateBy.Day,
                "period" => CustomTagUsageReportDataAggregateBy.Period,
                _ => null,
            };
        }
    }
}