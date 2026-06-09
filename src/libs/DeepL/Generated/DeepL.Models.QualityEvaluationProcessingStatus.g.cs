
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Example: processing
    /// </summary>
    public enum QualityEvaluationProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityEvaluationProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityEvaluationProcessingStatus value)
        {
            return value switch
            {
                QualityEvaluationProcessingStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityEvaluationProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => QualityEvaluationProcessingStatus.Processing,
                _ => null,
            };
        }
    }
}