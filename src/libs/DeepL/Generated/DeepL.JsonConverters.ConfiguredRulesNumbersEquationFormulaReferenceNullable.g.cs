#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesNumbersEquationFormulaReferenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.ConfiguredRulesNumbersEquationFormulaReference?>
    {
        /// <inheritdoc />
        public override global::DeepL.ConfiguredRulesNumbersEquationFormulaReference? Read(
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
                        return global::DeepL.ConfiguredRulesNumbersEquationFormulaReferenceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.ConfiguredRulesNumbersEquationFormulaReference)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.ConfiguredRulesNumbersEquationFormulaReference?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.ConfiguredRulesNumbersEquationFormulaReference? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepL.ConfiguredRulesNumbersEquationFormulaReferenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
