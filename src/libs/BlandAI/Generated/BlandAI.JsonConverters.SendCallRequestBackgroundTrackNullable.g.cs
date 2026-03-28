#nullable enable

namespace BlandAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SendCallRequestBackgroundTrackNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlandAI.SendCallRequestBackgroundTrack?>
    {
        /// <inheritdoc />
        public override global::BlandAI.SendCallRequestBackgroundTrack? Read(
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
                        return global::BlandAI.SendCallRequestBackgroundTrackExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlandAI.SendCallRequestBackgroundTrack)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlandAI.SendCallRequestBackgroundTrack?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlandAI.SendCallRequestBackgroundTrack? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BlandAI.SendCallRequestBackgroundTrackExtensions.ToValueString(value.Value));
            }
        }
    }
}
