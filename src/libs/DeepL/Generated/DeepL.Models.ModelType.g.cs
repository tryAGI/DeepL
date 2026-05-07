
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Specifies which DeepL model should be used for translation.
    /// </summary>
    public enum ModelType
    {
        /// <summary>
        /// 
        /// </summary>
        LatencyOptimized,
        /// <summary>
        /// 
        /// </summary>
        PreferQualityOptimized,
        /// <summary>
        /// 
        /// </summary>
        QualityOptimized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelType value)
        {
            return value switch
            {
                ModelType.LatencyOptimized => "latency_optimized",
                ModelType.PreferQualityOptimized => "prefer_quality_optimized",
                ModelType.QualityOptimized => "quality_optimized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelType? ToEnum(string value)
        {
            return value switch
            {
                "latency_optimized" => ModelType.LatencyOptimized,
                "prefer_quality_optimized" => ModelType.PreferQualityOptimized,
                "quality_optimized" => ModelType.QualityOptimized,
                _ => null,
            };
        }
    }
}