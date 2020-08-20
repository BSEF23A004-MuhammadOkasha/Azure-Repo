// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitArpTable
    {
        internal static ExpressRouteCircuitArpTable DeserializeExpressRouteCircuitArpTable(JsonElement element)
        {
            Optional<int> age = default;
            Optional<string> @interface = default;
            Optional<string> ipAddress = default;
            Optional<string> macAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("age"))
                {
                    age = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("interface"))
                {
                    @interface = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressRouteCircuitArpTable(Optional.ToNullable(age), @interface.Value, ipAddress.Value, macAddress.Value);
        }
    }
}
