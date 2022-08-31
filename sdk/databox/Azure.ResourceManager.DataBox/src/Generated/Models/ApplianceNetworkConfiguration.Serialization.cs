// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ApplianceNetworkConfiguration
    {
        internal static ApplianceNetworkConfiguration DeserializeApplianceNetworkConfiguration(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> macAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
            }
            return new ApplianceNetworkConfiguration(name.Value, macAddress.Value);
        }
    }
}
