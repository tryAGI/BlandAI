
#nullable enable

namespace BlandAI
{
    /// <summary>
    /// Default Value: audio/wav
    /// </summary>
    public enum GetCallRecordingContentType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioDividempeg,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCallRecordingContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCallRecordingContentType value)
        {
            return value switch
            {
                GetCallRecordingContentType.AudioDividempeg => "audio/mpeg",
                GetCallRecordingContentType.AudioDividewav => "audio/wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCallRecordingContentType? ToEnum(string value)
        {
            return value switch
            {
                "audio/mpeg" => GetCallRecordingContentType.AudioDividempeg,
                "audio/wav" => GetCallRecordingContentType.AudioDividewav,
                _ => null,
            };
        }
    }
}