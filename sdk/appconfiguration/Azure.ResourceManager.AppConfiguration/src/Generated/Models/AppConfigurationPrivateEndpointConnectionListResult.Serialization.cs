// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    internal partial class AppConfigurationPrivateEndpointConnectionListResult
    {
        internal static AppConfigurationPrivateEndpointConnectionListResult DeserializeAppConfigurationPrivateEndpointConnectionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AppConfigurationPrivateEndpointConnectionData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppConfigurationPrivateEndpointConnectionData> array = new List<AppConfigurationPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppConfigurationPrivateEndpointConnectionData.DeserializeAppConfigurationPrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AppConfigurationPrivateEndpointConnectionListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
