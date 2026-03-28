#nullable enable

namespace BlandAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SendCallRequestWebhookEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlandAI.SendCallRequestWebhookEvent>
    {
        /// <inheritdoc />
        public override global::BlandAI.SendCallRequestWebhookEvent Read(
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
                        return global::BlandAI.SendCallRequestWebhookEventExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlandAI.SendCallRequestWebhookEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlandAI.SendCallRequestWebhookEvent);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlandAI.SendCallRequestWebhookEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BlandAI.SendCallRequestWebhookEventExtensions.ToValueString(value));
        }
    }
}
