
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Default Value: period
    /// </summary>
    public enum AdminGetCustomTagAnalyticsAggregateBy
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
    public static class AdminGetCustomTagAnalyticsAggregateByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminGetCustomTagAnalyticsAggregateBy value)
        {
            return value switch
            {
                AdminGetCustomTagAnalyticsAggregateBy.Day => "day",
                AdminGetCustomTagAnalyticsAggregateBy.Period => "period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminGetCustomTagAnalyticsAggregateBy? ToEnum(string value)
        {
            return value switch
            {
                "day" => AdminGetCustomTagAnalyticsAggregateBy.Day,
                "period" => AdminGetCustomTagAnalyticsAggregateBy.Period,
                _ => null,
            };
        }
    }
}