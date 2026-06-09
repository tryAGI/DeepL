#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class QualityEvaluationIssueTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.QualityEvaluationIssueType>
    {
        /// <inheritdoc />
        public override global::DeepL.QualityEvaluationIssueType Read(
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
                        return global::DeepL.QualityEvaluationIssueTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.QualityEvaluationIssueType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.QualityEvaluationIssueType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.QualityEvaluationIssueType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepL.QualityEvaluationIssueTypeExtensions.ToValueString(value));
        }
    }
}
