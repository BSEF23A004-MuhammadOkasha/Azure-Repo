// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MethodRequestEmptyBodyBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static MethodRequestEmptyBodyBase DeserializeMethodRequestEmptyBodyBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("methodName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "livePipelineActivate": return LivePipelineActivateRequest.DeserializeLivePipelineActivateRequest(element);
                    case "livePipelineDeactivate": return LivePipelineDeactivateRequest.DeserializeLivePipelineDeactivateRequest(element);
                    case "livePipelineDelete": return LivePipelineDeleteRequest.DeserializeLivePipelineDeleteRequest(element);
                    case "livePipelineGet": return LivePipelineGetRequest.DeserializeLivePipelineGetRequest(element);
                    case "pipelineTopologyDelete": return PipelineTopologyDeleteRequest.DeserializePipelineTopologyDeleteRequest(element);
                    case "pipelineTopologyGet": return PipelineTopologyGetRequest.DeserializePipelineTopologyGetRequest(element);
                    case "remoteDeviceAdapterDelete": return RemoteDeviceAdapterDeleteRequest.DeserializeRemoteDeviceAdapterDeleteRequest(element);
                    case "remoteDeviceAdapterGet": return RemoteDeviceAdapterGetRequest.DeserializeRemoteDeviceAdapterGetRequest(element);
                }
            }
            string name = default;
            string methodName = "MethodRequestEmptyBodyBase";
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
            return new MethodRequestEmptyBodyBase(methodName, apiVersion.Value, name);
        }
    }
}
