// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataLakeStorageAccountDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AccountUri))
            {
                writer.WritePropertyName("accountUrl"u8);
                writer.WriteStringValue(AccountUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(Filesystem))
            {
                writer.WritePropertyName("filesystem"u8);
                writer.WriteStringValue(Filesystem);
            }
            if (Core.Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Core.Optional.IsDefined(CreateManagedPrivateEndpoint))
            {
                writer.WritePropertyName("createManagedPrivateEndpoint"u8);
                writer.WriteBooleanValue(CreateManagedPrivateEndpoint.Value);
            }
            writer.WriteEndObject();
        }

        internal static SynapseDataLakeStorageAccountDetails DeserializeSynapseDataLakeStorageAccountDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> accountUrl = default;
            Core.Optional<string> filesystem = default;
            Core.Optional<ResourceIdentifier> resourceId = default;
            Core.Optional<bool> createManagedPrivateEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filesystem"u8))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createManagedPrivateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createManagedPrivateEndpoint = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SynapseDataLakeStorageAccountDetails(accountUrl.Value, filesystem.Value, resourceId.Value, Core.Optional.ToNullable(createManagedPrivateEndpoint));
        }
    }
}
