// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class DeploymentConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation");
                writer.WriteStringValue(AppLocation);
            }
            if (Optional.IsDefined(InfrastructureConfiguration))
            {
                writer.WritePropertyName("infrastructureConfiguration");
                writer.WriteObjectValue(InfrastructureConfiguration);
            }
            if (Optional.IsDefined(SoftwareConfiguration))
            {
                writer.WritePropertyName("softwareConfiguration");
                writer.WriteObjectValue(SoftwareConfiguration);
            }
            writer.WritePropertyName("configurationType");
            writer.WriteStringValue(ConfigurationType.ToString());
            writer.WriteEndObject();
        }

        internal static DeploymentConfiguration DeserializeDeploymentConfiguration(JsonElement element)
        {
            Optional<string> appLocation = default;
            Optional<InfrastructureConfiguration> infrastructureConfiguration = default;
            Optional<SoftwareConfiguration> softwareConfiguration = default;
            SAPConfigurationType configurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"))
                {
                    appLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("infrastructureConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    infrastructureConfiguration = InfrastructureConfiguration.DeserializeInfrastructureConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("softwareConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    softwareConfiguration = SoftwareConfiguration.DeserializeSoftwareConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("configurationType"))
                {
                    configurationType = new SAPConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new DeploymentConfiguration(configurationType, appLocation.Value, infrastructureConfiguration.Value, softwareConfiguration.Value);
        }
    }
}
