
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Sets whether the translated text should lean towards formal or informal language.<br/>
    /// This feature is only available for certain target languages. Setting this parameter<br/>
    /// with a target language that does not support formality will fail, unless one of the<br/>
    /// `prefer_...` options are used.<br/>
    /// Possible options are:<br/>
    ///   * `default` (default)<br/>
    ///   * `more` - for a more formal language<br/>
    ///   * `less` - for a more informal language<br/>
    ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
    ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
    /// Default Value: default<br/>
    /// Example: prefer_more
    /// </summary>
    public enum Formality
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Less,
        /// <summary>
        /// 
        /// </summary>
        More,
        /// <summary>
        /// 
        /// </summary>
        PreferLess,
        /// <summary>
        /// 
        /// </summary>
        PreferMore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Formality value)
        {
            return value switch
            {
                Formality.Default => "default",
                Formality.Less => "less",
                Formality.More => "more",
                Formality.PreferLess => "prefer_less",
                Formality.PreferMore => "prefer_more",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Formality? ToEnum(string value)
        {
            return value switch
            {
                "default" => Formality.Default,
                "less" => Formality.Less,
                "more" => Formality.More,
                "prefer_less" => Formality.PreferLess,
                "prefer_more" => Formality.PreferMore,
                _ => null,
            };
        }
    }
}