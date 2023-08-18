// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DeployerVmPackages : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PackageUri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(PackageUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            writer.WriteEndObject();
        }

        internal static DeployerVmPackages DeserializeDeployerVmPackages(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> url = default;
            Core.Optional<string> storageAccountId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
            }
            return new DeployerVmPackages(url.Value, storageAccountId.Value);
        }
    }
}
