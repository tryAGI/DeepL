
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetLanguagesResource
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
        /// `translate_text`, `translate_document`,
        /// </summary>
        TranslateDocument,
        /// <summary>
        /// `translate_text`, `translate_document`,
        /// </summary>
        TranslateText,
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
    public static class GetLanguagesResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguagesResource value)
        {
            return value switch
            {
                GetLanguagesResource.Glossary => "glossary",
                GetLanguagesResource.StyleRules => "style_rules",
                GetLanguagesResource.TranslateDocument => "translate_document",
                GetLanguagesResource.TranslateText => "translate_text",
                GetLanguagesResource.Voice => "voice",
                GetLanguagesResource.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguagesResource? ToEnum(string value)
        {
            return value switch
            {
                "glossary" => GetLanguagesResource.Glossary,
                "style_rules" => GetLanguagesResource.StyleRules,
                "translate_document" => GetLanguagesResource.TranslateDocument,
                "translate_text" => GetLanguagesResource.TranslateText,
                "voice" => GetLanguagesResource.Voice,
                "write" => GetLanguagesResource.Write,
                _ => null,
            };
        }
    }
}