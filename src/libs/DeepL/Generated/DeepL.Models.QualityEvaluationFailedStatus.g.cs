
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Example: error
    /// </summary>
    public enum QualityEvaluationFailedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityEvaluationFailedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityEvaluationFailedStatus value)
        {
            return value switch
            {
                QualityEvaluationFailedStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityEvaluationFailedStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => QualityEvaluationFailedStatus.Error,
                _ => null,
            };
        }
    }
}