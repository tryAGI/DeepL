
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Disable the automatic detection of XML structure by setting the `outline_detection` parameter <br/>
    /// to `false` and selecting the tags that should be considered structure tags. This will split sentences <br/>
    /// using the `splitting_tags` parameter.<br/>
    /// Default Value: 1
    /// </summary>
    public enum OutlineDetectionOptionStr
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutlineDetectionOptionStrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutlineDetectionOptionStr value)
        {
            return value switch
            {
                OutlineDetectionOptionStr.x0 => "0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutlineDetectionOptionStr? ToEnum(string value)
        {
            return value switch
            {
                "0" => OutlineDetectionOptionStr.x0,
                _ => null,
            };
        }
    }
}