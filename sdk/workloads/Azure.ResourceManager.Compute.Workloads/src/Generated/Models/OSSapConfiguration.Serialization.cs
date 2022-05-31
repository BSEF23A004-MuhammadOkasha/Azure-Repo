// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class OSSapConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeployerVmPackages))
            {
                writer.WritePropertyName("deployerVmPackages");
                writer.WriteObjectValue(DeployerVmPackages);
            }
            if (Optional.IsDefined(SapFqdn))
            {
                writer.WritePropertyName("sapFqdn");
                writer.WriteStringValue(SapFqdn);
            }
            writer.WriteEndObject();
        }

        internal static OSSapConfiguration DeserializeOSSapConfiguration(JsonElement element)
        {
            Optional<DeployerVmPackages> deployerVmPackages = default;
            Optional<string> sapFqdn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deployerVmPackages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deployerVmPackages = DeployerVmPackages.DeserializeDeployerVmPackages(property.Value);
                    continue;
                }
                if (property.NameEquals("sapFqdn"))
                {
                    sapFqdn = property.Value.GetString();
                    continue;
                }
            }
            return new OSSapConfiguration(deployerVmPackages.Value, sapFqdn.Value);
        }
    }
}
