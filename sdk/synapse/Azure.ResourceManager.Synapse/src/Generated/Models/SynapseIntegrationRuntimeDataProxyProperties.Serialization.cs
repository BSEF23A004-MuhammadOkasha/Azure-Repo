// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeDataProxyProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Core.Optional.IsDefined(StagingLinkedService))
            {
                writer.WritePropertyName("stagingLinkedService"u8);
                writer.WriteObjectValue(StagingLinkedService);
            }
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
        }

        internal static SynapseIntegrationRuntimeDataProxyProperties DeserializeSynapseIntegrationRuntimeDataProxyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<SynapseEntityReference> connectVia = default;
            Core.Optional<SynapseEntityReference> stagingLinkedService = default;
            Core.Optional<string> path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = SynapseEntityReference.DeserializeSynapseEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("stagingLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stagingLinkedService = SynapseEntityReference.DeserializeSynapseEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseIntegrationRuntimeDataProxyProperties(connectVia.Value, stagingLinkedService.Value, path.Value);
        }
    }
}
