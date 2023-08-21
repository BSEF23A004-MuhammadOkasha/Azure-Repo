// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class OutboundEndpointDetail
    {
        internal static OutboundEndpointDetail DeserializeOutboundEndpointDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> ipAddress = default;
            Optional<int> port = default;
            Optional<double> latency = default;
            Optional<bool> isAccessible = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("latency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latency = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isAccessible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAccessible = property.Value.GetBoolean();
                    continue;
                }
            }
            return new OutboundEndpointDetail(ipAddress.Value, Optional.ToNullable(port), Optional.ToNullable(latency), Optional.ToNullable(isAccessible));
        }
    }
}
