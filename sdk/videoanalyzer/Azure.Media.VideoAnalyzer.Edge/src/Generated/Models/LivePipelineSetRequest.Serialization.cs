// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class LivePipelineSetRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("livePipeline"u8);
            writer.WriteObjectValue(LivePipeline);
            writer.WritePropertyName("methodName"u8);
            writer.WriteStringValue(MethodName);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static LivePipelineSetRequest DeserializeLivePipelineSetRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LivePipeline livePipeline = default;
            string methodName = default;
            string apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livePipeline"u8))
                {
                    livePipeline = LivePipeline.DeserializeLivePipeline(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new LivePipelineSetRequest(methodName, apiVersion, livePipeline);
        }
    }
}
