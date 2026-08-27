
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The resource identifier.<br/>
    /// Example: translate_text
    /// </summary>
    public enum GetLanguageResourcesResponseItemName
    {
        /// <summary>
        ///
        /// </summary>
        Glossary,
        /// <summary>
        ///
        /// </summary>
        StyleRules,
        /// <summary>
        ///
        /// </summary>
        TranslateDocument,
        /// <summary>
        ///
        /// </summary>
        TranslateText,
        /// <summary>
        ///
        /// </summary>
        TranslationMemory,
        /// <summary>
        ///
        /// </summary>
        Voice,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLanguageResourcesResponseItemNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguageResourcesResponseItemName value)
        {
            return value switch
            {
                GetLanguageResourcesResponseItemName.Glossary => "glossary",
                GetLanguageResourcesResponseItemName.StyleRules => "style_rules",
                GetLanguageResourcesResponseItemName.TranslateDocument => "translate_document",
                GetLanguageResourcesResponseItemName.TranslateText => "translate_text",
                GetLanguageResourcesResponseItemName.TranslationMemory => "translation_memory",
                GetLanguageResourcesResponseItemName.Voice => "voice",
                GetLanguageResourcesResponseItemName.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguageResourcesResponseItemName? ToEnum(string value)
        {
            return value switch
            {
                "glossary" => GetLanguageResourcesResponseItemName.Glossary,
                "style_rules" => GetLanguageResourcesResponseItemName.StyleRules,
                "translate_document" => GetLanguageResourcesResponseItemName.TranslateDocument,
                "translate_text" => GetLanguageResourcesResponseItemName.TranslateText,
                "translation_memory" => GetLanguageResourcesResponseItemName.TranslationMemory,
                "voice" => GetLanguageResourcesResponseItemName.Voice,
                "write" => GetLanguageResourcesResponseItemName.Write,
                _ => null,
            };
        }
    }
}