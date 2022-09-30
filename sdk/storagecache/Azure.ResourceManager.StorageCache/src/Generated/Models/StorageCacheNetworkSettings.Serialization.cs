// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheNetworkSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mtu))
            {
                writer.WritePropertyName("mtu");
                writer.WriteNumberValue(Mtu.Value);
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers");
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsSearchDomain))
            {
                writer.WritePropertyName("dnsSearchDomain");
                writer.WriteStringValue(DnsSearchDomain);
            }
            if (Optional.IsDefined(NtpServer))
            {
                writer.WritePropertyName("ntpServer");
                writer.WriteStringValue(NtpServer);
            }
            writer.WriteEndObject();
        }

        internal static StorageCacheNetworkSettings DeserializeStorageCacheNetworkSettings(JsonElement element)
        {
            Optional<int> mtu = default;
            Optional<IReadOnlyList<IPAddress>> utilityAddresses = default;
            Optional<IList<IPAddress>> dnsServers = default;
            Optional<string> dnsSearchDomain = default;
            Optional<string> ntpServer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtu"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mtu = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utilityAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddress.Parse(item.GetString()));
                    }
                    utilityAddresses = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddress.Parse(item.GetString()));
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("dnsSearchDomain"))
                {
                    dnsSearchDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ntpServer"))
                {
                    ntpServer = property.Value.GetString();
                    continue;
                }
            }
            return new StorageCacheNetworkSettings(Optional.ToNullable(mtu), Optional.ToList(utilityAddresses), Optional.ToList(dnsServers), dnsSearchDomain.Value, ntpServer.Value);
        }
    }
}
