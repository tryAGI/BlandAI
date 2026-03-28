#nullable enable

namespace BlandAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateInboundNumberRequestModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlandAI.UpdateInboundNumberRequestModel>
    {
        /// <inheritdoc />
        public override global::BlandAI.UpdateInboundNumberRequestModel Read(
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
                        return global::BlandAI.UpdateInboundNumberRequestModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlandAI.UpdateInboundNumberRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlandAI.UpdateInboundNumberRequestModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlandAI.UpdateInboundNumberRequestModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BlandAI.UpdateInboundNumberRequestModelExtensions.ToValueString(value));
        }
    }
}
