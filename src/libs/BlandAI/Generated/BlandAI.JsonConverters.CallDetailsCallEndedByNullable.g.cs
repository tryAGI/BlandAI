#nullable enable

namespace BlandAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallDetailsCallEndedByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlandAI.CallDetailsCallEndedBy?>
    {
        /// <inheritdoc />
        public override global::BlandAI.CallDetailsCallEndedBy? Read(
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
                        return global::BlandAI.CallDetailsCallEndedByExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlandAI.CallDetailsCallEndedBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlandAI.CallDetailsCallEndedBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlandAI.CallDetailsCallEndedBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BlandAI.CallDetailsCallEndedByExtensions.ToValueString(value.Value));
            }
        }
    }
}
