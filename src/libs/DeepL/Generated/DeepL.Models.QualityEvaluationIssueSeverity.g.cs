
#nullable enable

namespace DeepL
{
    /// <summary>
    /// How serious the issue is. See [Severity values](/api-reference/quality-evaluation/poll#severity-values).<br/>
    /// Example: Critical
    /// </summary>
    public enum QualityEvaluationIssueSeverity
    {
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        Major,
        /// <summary>
        ///
        /// </summary>
        Minor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityEvaluationIssueSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityEvaluationIssueSeverity value)
        {
            return value switch
            {
                QualityEvaluationIssueSeverity.Critical => "Critical",
                QualityEvaluationIssueSeverity.Major => "Major",
                QualityEvaluationIssueSeverity.Minor => "Minor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityEvaluationIssueSeverity? ToEnum(string value)
        {
            return value switch
            {
                "Critical" => QualityEvaluationIssueSeverity.Critical,
                "Major" => QualityEvaluationIssueSeverity.Major,
                "Minor" => QualityEvaluationIssueSeverity.Minor,
                _ => null,
            };
        }
    }
}