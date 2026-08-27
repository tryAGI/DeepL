
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVoiceTranslateJobIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        SignedUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoiceTranslateJobIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceTranslateJobIncludeItem value)
        {
            return value switch
            {
                CreateVoiceTranslateJobIncludeItem.SignedUrl => "signed_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceTranslateJobIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "signed_url" => CreateVoiceTranslateJobIncludeItem.SignedUrl,
                _ => null,
            };
        }
    }
}