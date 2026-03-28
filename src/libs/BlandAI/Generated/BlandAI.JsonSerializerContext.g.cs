
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace BlandAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::BlandAI.JsonConverters.SendCallRequestModelJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallRequestModelNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallRequestBackgroundTrackJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallRequestBackgroundTrackNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallRequestWebhookEventJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallRequestWebhookEventNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.UpdateInboundNumberRequestModelJsonConverter),

            typeof(global::BlandAI.JsonConverters.UpdateInboundNumberRequestModelNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.UpdateInboundNumberRequestBackgroundTrackJsonConverter),

            typeof(global::BlandAI.JsonConverters.UpdateInboundNumberRequestBackgroundTrackNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.PurchaseNumberRequestCountryCodeJsonConverter),

            typeof(global::BlandAI.JsonConverters.PurchaseNumberRequestCountryCodeNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.VoicemailConfigActionJsonConverter),

            typeof(global::BlandAI.JsonConverters.VoicemailConfigActionNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallResponseStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.SendCallResponseStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsQueueStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsQueueStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsAnsweredByJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsAnsweredByNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsCallEndedByJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsCallEndedByNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.CallDetailsStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.ActiveCallStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.ActiveCallStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.AnalyzeCallResponseStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.AnalyzeCallResponseStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.StatusResponseStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.StatusResponseStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.ErrorResponseStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.ErrorResponseStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.CreatePathwayResponseStatusJsonConverter),

            typeof(global::BlandAI.JsonConverters.CreatePathwayResponseStatusNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.ListCallsSortByJsonConverter),

            typeof(global::BlandAI.JsonConverters.ListCallsSortByNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.GetCallRecordingContentTypeJsonConverter),

            typeof(global::BlandAI.JsonConverters.GetCallRecordingContentTypeNullableJsonConverter),

            typeof(global::BlandAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallRequestModel), TypeInfoPropertyName = "SendCallRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallRequestBackgroundTrack), TypeInfoPropertyName = "SendCallRequestBackgroundTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.VoicemailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.SendCallRequestPronunciationGuideItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallRequestPronunciationGuideItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.SendCallRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallRequestWebhookEvent), TypeInfoPropertyName = "SendCallRequestWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.AnalyzeCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.CreateBatchRequestCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CreateBatchRequestCallObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CreatePathwayRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.UpdatePathwayRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.PathwayNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.PathwayNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.PathwayEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.PathwayEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.UpdateInboundNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.UpdateInboundNumberRequestModel), TypeInfoPropertyName = "UpdateInboundNumberRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.UpdateInboundNumberRequestBackgroundTrack), TypeInfoPropertyName = "UpdateInboundNumberRequestBackgroundTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.PurchaseNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.PurchaseNumberRequestCountryCode), TypeInfoPropertyName = "PurchaseNumberRequestCountryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.VoicemailConfigAction), TypeInfoPropertyName = "VoicemailConfigAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.SendCallResponseStatus), TypeInfoPropertyName = "SendCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ListCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.CallSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CallSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CallDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CallDetailsQueueStatus), TypeInfoPropertyName = "CallDetailsQueueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CallDetailsAnsweredBy), TypeInfoPropertyName = "CallDetailsAnsweredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CallDetailsCallEndedBy), TypeInfoPropertyName = "CallDetailsCallEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.TranscriptEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.TranscriptEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CallDetailsStatus), TypeInfoPropertyName = "CallDetailsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ActiveCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ActiveCallStatus), TypeInfoPropertyName = "ActiveCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.AnalyzeCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.AnalyzeCallResponseStatus), TypeInfoPropertyName = "AnalyzeCallResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.StatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.StatusResponseStatus), TypeInfoPropertyName = "StatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ErrorResponseStatus), TypeInfoPropertyName = "ErrorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.DataResponseBatchId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.DataResponseBatchIdData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.DataResponseBatchList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.DataResponseBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.DataResponseNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.DataResponseBatchLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.BatchLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.BatchLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.Pathway))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.PathwayEdgeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CreatePathwayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.CreatePathwayResponseStatus), TypeInfoPropertyName = "CreatePathwayResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ListInboundNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.InboundNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.InboundNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.AccountDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.AccountDetailsBilling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ListCallsSortBy), TypeInfoPropertyName = "ListCallsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.GetCallRecordingContentType), TypeInfoPropertyName = "GetCallRecordingContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlandAI.ListActiveCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.ActiveCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.Pathway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlandAI.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.SendCallRequestPronunciationGuideItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.SendCallRequestWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.CreateBatchRequestCallObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.PathwayNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.PathwayEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.CallSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.TranscriptEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.BatchLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.InboundNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.ActiveCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.Pathway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlandAI.Voice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}