// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeReplication
    {
        internal static NetAppVolumeReplication DeserializeNetAppVolumeReplication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetAppEndpointType> endpointType = default;
            Optional<NetAppReplicationSchedule> replicationSchedule = default;
            ResourceIdentifier remoteVolumeResourceId = default;
            Optional<string> remoteVolumeRegion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointType = new NetAppEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationSchedule = new NetAppReplicationSchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeResourceId"u8))
                {
                    remoteVolumeResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeRegion"u8))
                {
                    remoteVolumeRegion = property.Value.GetString();
                    continue;
                }
            }
            return new NetAppVolumeReplication(Optional.ToNullable(endpointType), Optional.ToNullable(replicationSchedule), remoteVolumeResourceId, remoteVolumeRegion.Value);
        }
    }
}
