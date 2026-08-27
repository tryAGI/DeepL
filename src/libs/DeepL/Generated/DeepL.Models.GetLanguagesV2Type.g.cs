
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Default Value: source
    /// </summary>
    public enum GetLanguagesV2Type
    {
        /// <summary>
        ///
        /// </summary>
        Source,
        /// <summary>
        ///
        /// </summary>
        Target,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLanguagesV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguagesV2Type value)
        {
            return value switch
            {
                GetLanguagesV2Type.Source => "source",
                GetLanguagesV2Type.Target => "target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguagesV2Type? ToEnum(string value)
        {
            return value switch
            {
                "source" => GetLanguagesV2Type.Source,
                "target" => GetLanguagesV2Type.Target,
                _ => null,
            };
        }
    }
}