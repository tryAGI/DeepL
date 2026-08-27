
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Sets which kind of tags should be handled. Options currently available:<br/>
    ///  * `xml`<br/>
    ///  * `html`<br/>
    /// Example: html
    /// </summary>
    public enum TagHandlingOption
    {
        /// <summary>
        ///
        /// </summary>
        Html,
        /// <summary>
        ///
        /// </summary>
        Xml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TagHandlingOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TagHandlingOption value)
        {
            return value switch
            {
                TagHandlingOption.Html => "html",
                TagHandlingOption.Xml => "xml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TagHandlingOption? ToEnum(string value)
        {
            return value switch
            {
                "html" => TagHandlingOption.Html,
                "xml" => TagHandlingOption.Xml,
                _ => null,
            };
        }
    }
}