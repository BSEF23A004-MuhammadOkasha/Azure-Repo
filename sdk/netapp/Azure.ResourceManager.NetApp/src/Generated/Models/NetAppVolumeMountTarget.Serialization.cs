// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeMountTarget
    {
        internal static NetAppVolumeMountTarget DeserializeNetAppVolumeMountTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> mountTargetId = default;
            Guid fileSystemId = default;
            Optional<IPAddress> ipAddress = default;
            Optional<string> smbServerFqdn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mountTargetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountTargetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("fileSystemId"u8))
                {
                    fileSystemId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("smbServerFqdn"u8))
                {
                    smbServerFqdn = property.Value.GetString();
                    continue;
                }
            }
            return new NetAppVolumeMountTarget(Optional.ToNullable(mountTargetId), fileSystemId, ipAddress.Value, smbServerFqdn.Value);
        }
    }
}
