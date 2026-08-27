
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Finer-grained category within `type`. See [Type and sub-type values](/api-reference/quality-evaluation/poll#type-and-sub-type-values).<br/>
    /// Example: Mistranslation
    /// </summary>
    public enum QualityEvaluationIssueSubType
    {
        /// <summary>
        ///
        /// </summary>
        Addition,
        /// <summary>
        ///
        /// </summary>
        Awkward,
        /// <summary>
        ///
        /// </summary>
        CharacterEncoding,
        /// <summary>
        ///
        /// </summary>
        Grammar,
        /// <summary>
        ///
        /// </summary>
        GrammaticalRegister,
        /// <summary>
        ///
        /// </summary>
        Inconsistency,
        /// <summary>
        ///
        /// </summary>
        InconsistentStyle,
        /// <summary>
        ///
        /// </summary>
        Mistranslation,
        /// <summary>
        ///
        /// </summary>
        Omission,
        /// <summary>
        ///
        /// </summary>
        OverTranslation,
        /// <summary>
        ///
        /// </summary>
        Punctuation,
        /// <summary>
        ///
        /// </summary>
        Spelling,
        /// <summary>
        ///
        /// </summary>
        UnderTranslation,
        /// <summary>
        ///
        /// </summary>
        UntranslatedText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityEvaluationIssueSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityEvaluationIssueSubType value)
        {
            return value switch
            {
                QualityEvaluationIssueSubType.Addition => "Addition",
                QualityEvaluationIssueSubType.Awkward => "Awkward",
                QualityEvaluationIssueSubType.CharacterEncoding => "Character encoding",
                QualityEvaluationIssueSubType.Grammar => "Grammar",
                QualityEvaluationIssueSubType.GrammaticalRegister => "Grammatical register",
                QualityEvaluationIssueSubType.Inconsistency => "Inconsistency",
                QualityEvaluationIssueSubType.InconsistentStyle => "Inconsistent style",
                QualityEvaluationIssueSubType.Mistranslation => "Mistranslation",
                QualityEvaluationIssueSubType.Omission => "Omission",
                QualityEvaluationIssueSubType.OverTranslation => "Over-translation",
                QualityEvaluationIssueSubType.Punctuation => "Punctuation",
                QualityEvaluationIssueSubType.Spelling => "Spelling",
                QualityEvaluationIssueSubType.UnderTranslation => "Under-translation",
                QualityEvaluationIssueSubType.UntranslatedText => "Untranslated text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityEvaluationIssueSubType? ToEnum(string value)
        {
            return value switch
            {
                "Addition" => QualityEvaluationIssueSubType.Addition,
                "Awkward" => QualityEvaluationIssueSubType.Awkward,
                "Character encoding" => QualityEvaluationIssueSubType.CharacterEncoding,
                "Grammar" => QualityEvaluationIssueSubType.Grammar,
                "Grammatical register" => QualityEvaluationIssueSubType.GrammaticalRegister,
                "Inconsistency" => QualityEvaluationIssueSubType.Inconsistency,
                "Inconsistent style" => QualityEvaluationIssueSubType.InconsistentStyle,
                "Mistranslation" => QualityEvaluationIssueSubType.Mistranslation,
                "Omission" => QualityEvaluationIssueSubType.Omission,
                "Over-translation" => QualityEvaluationIssueSubType.OverTranslation,
                "Punctuation" => QualityEvaluationIssueSubType.Punctuation,
                "Spelling" => QualityEvaluationIssueSubType.Spelling,
                "Under-translation" => QualityEvaluationIssueSubType.UnderTranslation,
                "Untranslated text" => QualityEvaluationIssueSubType.UntranslatedText,
                _ => null,
            };
        }
    }
}