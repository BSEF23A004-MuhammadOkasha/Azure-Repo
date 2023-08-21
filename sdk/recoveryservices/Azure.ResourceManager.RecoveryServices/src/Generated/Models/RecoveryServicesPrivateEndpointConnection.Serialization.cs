// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RecoveryServicesPrivateEndpointConnection
    {
        internal static RecoveryServicesPrivateEndpointConnection DeserializeRecoveryServicesPrivateEndpointConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RecoveryServicesPrivateEndpointConnectionProvisioningState> provisioningState = default;
            Optional<SubResource> privateEndpoint = default;
            Optional<RecoveryServicesPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            Optional<IReadOnlyList<VaultSubResourceType>> groupIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new RecoveryServicesPrivateEndpointConnectionProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = RecoveryServicesPrivateLinkServiceConnectionState.DeserializeRecoveryServicesPrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (property.NameEquals("groupIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VaultSubResourceType> array = new List<VaultSubResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VaultSubResourceType(item.GetString()));
                    }
                    groupIds = array;
                    continue;
                }
            }
            return new RecoveryServicesPrivateEndpointConnection(Optional.ToNullable(provisioningState), privateEndpoint, privateLinkServiceConnectionState.Value, Optional.ToList(groupIds));
        }
    }
}
