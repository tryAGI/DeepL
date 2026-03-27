#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdminGetAnalyticsGroupByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.AdminGetAnalyticsGroupBy?>
    {
        /// <inheritdoc />
        public override global::DeepL.AdminGetAnalyticsGroupBy? Read(
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
                        return global::DeepL.AdminGetAnalyticsGroupByExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.AdminGetAnalyticsGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.AdminGetAnalyticsGroupBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.AdminGetAnalyticsGroupBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepL.AdminGetAnalyticsGroupByExtensions.ToValueString(value.Value));
            }
        }
    }
}
