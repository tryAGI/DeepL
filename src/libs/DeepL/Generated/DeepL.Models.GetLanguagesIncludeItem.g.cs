
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetLanguagesIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLanguagesIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguagesIncludeItem value)
        {
            return value switch
            {
                GetLanguagesIncludeItem.Beta => "beta",
                GetLanguagesIncludeItem.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguagesIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "beta" => GetLanguagesIncludeItem.Beta,
                "external" => GetLanguagesIncludeItem.External,
                _ => null,
            };
        }
    }
}