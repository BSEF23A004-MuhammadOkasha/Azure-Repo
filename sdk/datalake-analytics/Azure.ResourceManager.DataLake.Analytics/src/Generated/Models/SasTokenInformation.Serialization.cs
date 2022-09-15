// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLake.Analytics.Models
{
    public partial class SasTokenInformation
    {
        internal static SasTokenInformation DeserializeSasTokenInformation(JsonElement element)
        {
            Optional<string> accessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
            }
            return new SasTokenInformation(accessToken.Value);
        }
    }
}
