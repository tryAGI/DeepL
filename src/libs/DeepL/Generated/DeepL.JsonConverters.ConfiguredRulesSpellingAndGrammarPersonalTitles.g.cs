#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesSpellingAndGrammarPersonalTitlesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles>
    {
        /// <inheritdoc />
        public override global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitlesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitles value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepL.ConfiguredRulesSpellingAndGrammarPersonalTitlesExtensions.ToValueString(value));
        }
    }
}
