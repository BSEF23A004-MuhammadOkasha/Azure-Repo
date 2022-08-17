// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Geolocation.Models
{
    public partial class CountryRegion
    {
        internal static CountryRegion DeserializeCountryRegion(JsonElement element)
        {
            Optional<string> isoCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isoCode"))
                {
                    isoCode = property.Value.GetString();
                    continue;
                }
            }
            return new CountryRegion(isoCode.Value);
        }
    }
}
