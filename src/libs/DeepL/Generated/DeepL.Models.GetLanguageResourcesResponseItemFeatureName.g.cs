
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The feature identifier, corresponding to keys in the `features` object returned by `GET /v3/languages`.
    /// </summary>
    public enum GetLanguageResourcesResponseItemFeatureName
    {
        /// <summary>
        /// 
        /// </summary>
        AutoDetection,
        /// <summary>
        /// 
        /// </summary>
        Formality,
        /// <summary>
        /// 
        /// </summary>
        Glossary,
        /// <summary>
        /// 
        /// </summary>
        SpokenTerms,
        /// <summary>
        /// 
        /// </summary>
        StyleRules,
        /// <summary>
        /// 
        /// </summary>
        TagHandling,
        /// <summary>
        /// 
        /// </summary>
        Tone,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        TranslatedSpeech,
        /// <summary>
        /// 
        /// </summary>
        TranslationMemory,
        /// <summary>
        /// 
        /// </summary>
        WritingStyle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLanguageResourcesResponseItemFeatureNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLanguageResourcesResponseItemFeatureName value)
        {
            return value switch
            {
                GetLanguageResourcesResponseItemFeatureName.AutoDetection => "auto_detection",
                GetLanguageResourcesResponseItemFeatureName.Formality => "formality",
                GetLanguageResourcesResponseItemFeatureName.Glossary => "glossary",
                GetLanguageResourcesResponseItemFeatureName.SpokenTerms => "spoken_terms",
                GetLanguageResourcesResponseItemFeatureName.StyleRules => "style_rules",
                GetLanguageResourcesResponseItemFeatureName.TagHandling => "tag_handling",
                GetLanguageResourcesResponseItemFeatureName.Tone => "tone",
                GetLanguageResourcesResponseItemFeatureName.Transcription => "transcription",
                GetLanguageResourcesResponseItemFeatureName.TranslatedSpeech => "translated_speech",
                GetLanguageResourcesResponseItemFeatureName.TranslationMemory => "translation_memory",
                GetLanguageResourcesResponseItemFeatureName.WritingStyle => "writing_style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLanguageResourcesResponseItemFeatureName? ToEnum(string value)
        {
            return value switch
            {
                "auto_detection" => GetLanguageResourcesResponseItemFeatureName.AutoDetection,
                "formality" => GetLanguageResourcesResponseItemFeatureName.Formality,
                "glossary" => GetLanguageResourcesResponseItemFeatureName.Glossary,
                "spoken_terms" => GetLanguageResourcesResponseItemFeatureName.SpokenTerms,
                "style_rules" => GetLanguageResourcesResponseItemFeatureName.StyleRules,
                "tag_handling" => GetLanguageResourcesResponseItemFeatureName.TagHandling,
                "tone" => GetLanguageResourcesResponseItemFeatureName.Tone,
                "transcription" => GetLanguageResourcesResponseItemFeatureName.Transcription,
                "translated_speech" => GetLanguageResourcesResponseItemFeatureName.TranslatedSpeech,
                "translation_memory" => GetLanguageResourcesResponseItemFeatureName.TranslationMemory,
                "writing_style" => GetLanguageResourcesResponseItemFeatureName.WritingStyle,
                _ => null,
            };
        }
    }
}