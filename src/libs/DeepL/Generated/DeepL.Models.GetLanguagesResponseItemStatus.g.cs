
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Availability status of this language.<br/>
    /// Example: stable
    /// </summary>
    public enum GetLanguagesResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        EarlyAccess,
        /// <summary>
        /// 
        /// </summary>
        Stable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLanguagesResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguagesResponseItemStatus value)
        {
            return value switch
            {
                GetLanguagesResponseItemStatus.Beta => "beta",
                GetLanguagesResponseItemStatus.EarlyAccess => "early_access",
                GetLanguagesResponseItemStatus.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguagesResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "beta" => GetLanguagesResponseItemStatus.Beta,
                "early_access" => GetLanguagesResponseItemStatus.EarlyAccess,
                "stable" => GetLanguagesResponseItemStatus.Stable,
                _ => null,
            };
        }
    }
}