
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The version of the tag handling algorithm used for the translation. Only present when the `tag_handling` parameter (`xml` or `html`) is set. If you don't specify `tag_handling_version`, this shows the default that was applied.<br/>
    /// Example: v2
    /// </summary>
    public enum TranslateTextResponseTranslationTagHandlingVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateTextResponseTranslationTagHandlingVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateTextResponseTranslationTagHandlingVersion value)
        {
            return value switch
            {
                TranslateTextResponseTranslationTagHandlingVersion.V1 => "v1",
                TranslateTextResponseTranslationTagHandlingVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateTextResponseTranslationTagHandlingVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => TranslateTextResponseTranslationTagHandlingVersion.V1,
                "v2" => TranslateTextResponseTranslationTagHandlingVersion.V2,
                _ => null,
            };
        }
    }
}