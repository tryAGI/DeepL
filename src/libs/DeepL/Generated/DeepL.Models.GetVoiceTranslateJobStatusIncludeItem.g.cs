
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoiceTranslateJobStatusIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        SignedUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVoiceTranslateJobStatusIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoiceTranslateJobStatusIncludeItem value)
        {
            return value switch
            {
                GetVoiceTranslateJobStatusIncludeItem.SignedUrl => "signed_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoiceTranslateJobStatusIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "signed_url" => GetVoiceTranslateJobStatusIncludeItem.SignedUrl,
                _ => null,
            };
        }
    }
}