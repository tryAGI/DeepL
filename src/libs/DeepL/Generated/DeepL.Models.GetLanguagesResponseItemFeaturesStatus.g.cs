
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Availability status of this feature for this language.
    /// </summary>
    public enum GetLanguagesResponseItemFeaturesStatus
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
    public static class GetLanguagesResponseItemFeaturesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguagesResponseItemFeaturesStatus value)
        {
            return value switch
            {
                GetLanguagesResponseItemFeaturesStatus.Beta => "beta",
                GetLanguagesResponseItemFeaturesStatus.EarlyAccess => "early_access",
                GetLanguagesResponseItemFeaturesStatus.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguagesResponseItemFeaturesStatus? ToEnum(string value)
        {
            return value switch
            {
                "beta" => GetLanguagesResponseItemFeaturesStatus.Beta,
                "early_access" => GetLanguagesResponseItemFeaturesStatus.EarlyAccess,
                "stable" => GetLanguagesResponseItemFeaturesStatus.Stable,
                _ => null,
            };
        }
    }
}