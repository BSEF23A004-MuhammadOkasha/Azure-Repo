// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ArmApplicationDeploymentPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deploymentMode"u8);
            writer.WriteStringValue(DeploymentMode.ToString());
            writer.WriteEndObject();
        }

        internal static ArmApplicationDeploymentPolicy DeserializeArmApplicationDeploymentPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmApplicationDeploymentMode deploymentMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentMode"u8))
                {
                    deploymentMode = new ArmApplicationDeploymentMode(property.Value.GetString());
                    continue;
                }
            }
            return new ArmApplicationDeploymentPolicy(deploymentMode);
        }
    }
}
