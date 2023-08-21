// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class StorageBlobDeadLetterDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(BlobContainerName))
            {
                writer.WritePropertyName("blobContainerName"u8);
                writer.WriteStringValue(BlobContainerName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageBlobDeadLetterDestination DeserializeStorageBlobDeadLetterDestination(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DeadLetterEndPointType endpointType = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> blobContainerName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new DeadLetterEndPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobContainerName"u8))
                        {
                            blobContainerName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageBlobDeadLetterDestination(endpointType, resourceId.Value, blobContainerName.Value);
        }
    }
}
