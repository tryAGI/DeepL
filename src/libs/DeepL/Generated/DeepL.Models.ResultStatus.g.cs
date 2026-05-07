
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The processing status of a target result.<br/>
    /// - `pending`: Job created, awaiting file upload.<br/>
    /// - `uploaded`: File uploaded, awaiting processing.<br/>
    /// - `processing`: Translation in progress.<br/>
    /// - `complete`: Translation complete, result available for download.<br/>
    /// - `downloaded`: Result has been downloaded. Assets are marked for deletion.<br/>
    /// - `failed`: Processing failed. See the `error` field for details.
    /// </summary>
    public enum ResultStatus
    {
        /// <summary>
        /// Translation complete, result available for download.
        /// </summary>
        Complete,
        /// <summary>
        /// Result has been downloaded. Assets are marked for deletion.
        /// </summary>
        Downloaded,
        /// <summary>
        /// Processing failed. See the `error` field for details.
        /// </summary>
        Failed,
        /// <summary>
        /// Job created, awaiting file upload.
        /// </summary>
        Pending,
        /// <summary>
        /// File uploaded, awaiting processing.
        /// </summary>
        Processing,
        /// <summary>
        /// File uploaded, awaiting processing.
        /// </summary>
        Uploaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResultStatus value)
        {
            return value switch
            {
                ResultStatus.Complete => "complete",
                ResultStatus.Downloaded => "downloaded",
                ResultStatus.Failed => "failed",
                ResultStatus.Pending => "pending",
                ResultStatus.Processing => "processing",
                ResultStatus.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => ResultStatus.Complete,
                "downloaded" => ResultStatus.Downloaded,
                "failed" => ResultStatus.Failed,
                "pending" => ResultStatus.Pending,
                "processing" => ResultStatus.Processing,
                "uploaded" => ResultStatus.Uploaded,
                _ => null,
            };
        }
    }
}