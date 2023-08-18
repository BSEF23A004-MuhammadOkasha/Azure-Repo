// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class OSSapConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DeployerVmPackages))
            {
                writer.WritePropertyName("deployerVmPackages"u8);
                writer.WriteObjectValue(DeployerVmPackages);
            }
            if (Core.Optional.IsDefined(SapFqdn))
            {
                writer.WritePropertyName("sapFqdn"u8);
                writer.WriteStringValue(SapFqdn);
            }
            writer.WriteEndObject();
        }

        internal static OSSapConfiguration DeserializeOSSapConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DeployerVmPackages> deployerVmPackages = default;
            Core.Optional<string> sapFqdn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deployerVmPackages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deployerVmPackages = DeployerVmPackages.DeserializeDeployerVmPackages(property.Value);
                    continue;
                }
                if (property.NameEquals("sapFqdn"u8))
                {
                    sapFqdn = property.Value.GetString();
                    continue;
                }
            }
            return new OSSapConfiguration(deployerVmPackages.Value, sapFqdn.Value);
        }
    }
}
