
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Sets whether the translation engine should first split the input into sentences.<br/>
    /// Possible values are:<br/>
    ///   * 0 - no splitting at all, whole input is treated as one sentence<br/>
    ///   * 1 (default when tag_handling is not set to html) - splits on punctuation and on newlines<br/>
    ///   * nonewlines (default when tag_handling=html) - splits on punctuation only, ignoring newlines<br/>
    /// Default Value: 1<br/>
    /// Example: 1
    /// </summary>
    public enum SplitSentencesOption
    {
        /// <summary>
        ///
        /// </summary>
        x0,
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        Nonewlines,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitSentencesOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitSentencesOption value)
        {
            return value switch
            {
                SplitSentencesOption.x0 => "0",
                SplitSentencesOption.x1 => "1",
                SplitSentencesOption.Nonewlines => "nonewlines",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitSentencesOption? ToEnum(string value)
        {
            return value switch
            {
                "0" => SplitSentencesOption.x0,
                "1" => SplitSentencesOption.x1,
                "nonewlines" => SplitSentencesOption.Nonewlines,
                _ => null,
            };
        }
    }
}