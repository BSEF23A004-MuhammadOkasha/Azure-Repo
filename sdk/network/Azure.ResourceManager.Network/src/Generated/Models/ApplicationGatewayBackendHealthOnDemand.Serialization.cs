// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendHealthOnDemand
    {
        internal static ApplicationGatewayBackendHealthOnDemand DeserializeApplicationGatewayBackendHealthOnDemand(JsonElement element)
        {
            Optional<ApplicationGatewayBackendAddressPool> backendAddressPool = default;
            Optional<ApplicationGatewayBackendHealthHttpSettings> backendHealthHttpSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendAddressPool"))
                {
                    backendAddressPool = ApplicationGatewayBackendAddressPool.DeserializeApplicationGatewayBackendAddressPool(property.Value);
                    continue;
                }
                if (property.NameEquals("backendHealthHttpSettings"))
                {
                    backendHealthHttpSettings = ApplicationGatewayBackendHealthHttpSettings.DeserializeApplicationGatewayBackendHealthHttpSettings(property.Value);
                    continue;
                }
            }
            return new ApplicationGatewayBackendHealthOnDemand(backendAddressPool.Value, backendHealthHttpSettings.Value);
        }
    }
}
