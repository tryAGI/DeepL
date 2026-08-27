
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Example: done
    /// </summary>
    public enum QualityEvaluationDoneStatus
    {
        /// <summary>
        ///
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityEvaluationDoneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityEvaluationDoneStatus value)
        {
            return value switch
            {
                QualityEvaluationDoneStatus.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityEvaluationDoneStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => QualityEvaluationDoneStatus.Done,
                _ => null,
            };
        }
    }
}