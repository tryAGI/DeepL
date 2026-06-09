
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Top-level category of the issue. See [Type and sub-type values](/api-reference/quality-evaluation/poll#type-and-sub-type-values).<br/>
    /// Example: Accuracy
    /// </summary>
    public enum QualityEvaluationIssueType
    {
        /// <summary>
        /// 
        /// </summary>
        Accuracy,
        /// <summary>
        /// 
        /// </summary>
        Fluency,
        /// <summary>
        /// 
        /// </summary>
        Miscellaneous,
        /// <summary>
        /// 
        /// </summary>
        Style,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityEvaluationIssueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityEvaluationIssueType value)
        {
            return value switch
            {
                QualityEvaluationIssueType.Accuracy => "Accuracy",
                QualityEvaluationIssueType.Fluency => "Fluency",
                QualityEvaluationIssueType.Miscellaneous => "Miscellaneous",
                QualityEvaluationIssueType.Style => "Style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityEvaluationIssueType? ToEnum(string value)
        {
            return value switch
            {
                "Accuracy" => QualityEvaluationIssueType.Accuracy,
                "Fluency" => QualityEvaluationIssueType.Fluency,
                "Miscellaneous" => QualityEvaluationIssueType.Miscellaneous,
                "Style" => QualityEvaluationIssueType.Style,
                _ => null,
            };
        }
    }
}