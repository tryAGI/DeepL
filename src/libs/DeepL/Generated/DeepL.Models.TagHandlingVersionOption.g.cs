
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Sets which version of the tag handling algorithm should be used. Options currently available:<br/>
    /// * `v1`: Traditional algorithm (currently the default, will become deprecated in the future).<br/>
    /// * `v2`: Improved algorithm released in October 2025 (will become the default in the future).
    /// </summary>
    public enum TagHandlingVersionOption
    {
        /// <summary>
        /// Traditional algorithm (currently the default, will become deprecated in the future).
        /// </summary>
        V1,
        /// <summary>
        /// Improved algorithm released in October 2025 (will become the default in the future).
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TagHandlingVersionOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TagHandlingVersionOption value)
        {
            return value switch
            {
                TagHandlingVersionOption.V1 => "v1",
                TagHandlingVersionOption.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TagHandlingVersionOption? ToEnum(string value)
        {
            return value switch
            {
                "v1" => TagHandlingVersionOption.V1,
                "v2" => TagHandlingVersionOption.V2,
                _ => null,
            };
        }
    }
}