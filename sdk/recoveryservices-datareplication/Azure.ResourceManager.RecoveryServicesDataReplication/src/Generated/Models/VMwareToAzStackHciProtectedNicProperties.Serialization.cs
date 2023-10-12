// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciProtectedNicProperties
    {
        internal static VMwareToAzStackHciProtectedNicProperties DeserializeVMwareToAzStackHciProtectedNicProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nicId = default;
            Optional<string> macAddress = default;
            Optional<string> label = default;
            Optional<bool> isPrimaryNic = default;
            Optional<string> networkName = default;
            Optional<string> targetNetworkId = default;
            Optional<string> testNetworkId = default;
            Optional<VmNicSelection> selectionTypeForFailover = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimaryNic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimaryNic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    testNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectionTypeForFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectionTypeForFailover = new VmNicSelection(property.Value.GetString());
                    continue;
                }
            }
            return new VMwareToAzStackHciProtectedNicProperties(nicId.Value, macAddress.Value, label.Value, Optional.ToNullable(isPrimaryNic), networkName.Value, targetNetworkId.Value, testNetworkId.Value, Optional.ToNullable(selectionTypeForFailover));
        }
    }
}
