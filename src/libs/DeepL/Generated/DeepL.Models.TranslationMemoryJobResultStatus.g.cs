
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The job's current state:<br/>
    ///  * `awaiting_input` - the job exists but the file has not been uploaded yet (import only)<br/>
    ///  * `processing` - the file was received and is being processed<br/>
    ///  * `completed` - the job finished successfully<br/>
    ///  * `failed` - the job did not finish; see `error`<br/>
    ///  * `expired` - the job is too old to act on; create a new one<br/>
    /// Example: completed
    /// </summary>
    public enum TranslationMemoryJobResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        AwaitingInput,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationMemoryJobResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationMemoryJobResultStatus value)
        {
            return value switch
            {
                TranslationMemoryJobResultStatus.AwaitingInput => "awaiting_input",
                TranslationMemoryJobResultStatus.Completed => "completed",
                TranslationMemoryJobResultStatus.Expired => "expired",
                TranslationMemoryJobResultStatus.Failed => "failed",
                TranslationMemoryJobResultStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationMemoryJobResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "awaiting_input" => TranslationMemoryJobResultStatus.AwaitingInput,
                "completed" => TranslationMemoryJobResultStatus.Completed,
                "expired" => TranslationMemoryJobResultStatus.Expired,
                "failed" => TranslationMemoryJobResultStatus.Failed,
                "processing" => TranslationMemoryJobResultStatus.Processing,
                _ => null,
            };
        }
    }
}