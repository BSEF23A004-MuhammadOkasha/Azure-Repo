// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class FqdnEndpoint
    {
        internal static FqdnEndpoint DeserializeFqdnEndpoint(JsonElement element)
        {
            Optional<string> domainName = default;
            Optional<IReadOnlyList<FqdnEndpointDetail>> endpointDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FqdnEndpointDetail> array = new List<FqdnEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FqdnEndpointDetail.DeserializeFqdnEndpointDetail(item));
                    }
                    endpointDetails = array;
                    continue;
                }
            }
            return new FqdnEndpoint(domainName.Value, Optional.ToList(endpointDetails));
        }
    }
}
