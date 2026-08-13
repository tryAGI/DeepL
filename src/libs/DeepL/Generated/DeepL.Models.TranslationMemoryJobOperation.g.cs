
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Which kind of job this is.<br/>
    /// Example: import
    /// </summary>
    public enum TranslationMemoryJobOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Export,
        /// <summary>
        /// 
        /// </summary>
        Import,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationMemoryJobOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationMemoryJobOperation value)
        {
            return value switch
            {
                TranslationMemoryJobOperation.Export => "export",
                TranslationMemoryJobOperation.Import => "import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationMemoryJobOperation? ToEnum(string value)
        {
            return value switch
            {
                "export" => TranslationMemoryJobOperation.Export,
                "import" => TranslationMemoryJobOperation.Import,
                _ => null,
            };
        }
    }
}