// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersAwsOfferingVaAutoProvisioning : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration");
                writer.WriteObjectValue(Configuration);
            }
            writer.WriteEndObject();
        }

        internal static DefenderForServersAwsOfferingVaAutoProvisioning DeserializeDefenderForServersAwsOfferingVaAutoProvisioning(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<DefenderForServersAwsOfferingVaAutoProvisioningConfiguration> configuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configuration = DefenderForServersAwsOfferingVaAutoProvisioningConfiguration.DeserializeDefenderForServersAwsOfferingVaAutoProvisioningConfiguration(property.Value);
                    continue;
                }
            }
            return new DefenderForServersAwsOfferingVaAutoProvisioning(Optional.ToNullable(enabled), configuration.Value);
        }
    }
}
