// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CreateAndMountFileShareConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Core.Optional.IsDefined(StorageAccountName))
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            writer.WriteEndObject();
        }

        internal static CreateAndMountFileShareConfiguration DeserializeCreateAndMountFileShareConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> resourceGroup = default;
            Core.Optional<string> storageAccountName = default;
            ConfigurationType configurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new CreateAndMountFileShareConfiguration(configurationType, resourceGroup.Value, storageAccountName.Value);
        }
    }
}
