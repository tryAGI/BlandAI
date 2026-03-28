#nullable enable

namespace BlandAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnalyzeCallResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlandAI.AnalyzeCallResponseStatus?>
    {
        /// <inheritdoc />
        public override global::BlandAI.AnalyzeCallResponseStatus? Read(
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
                        return global::BlandAI.AnalyzeCallResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlandAI.AnalyzeCallResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlandAI.AnalyzeCallResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlandAI.AnalyzeCallResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BlandAI.AnalyzeCallResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
