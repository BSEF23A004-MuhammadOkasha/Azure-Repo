// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    internal partial class NginxCertificateListResponse
    {
        internal static NginxCertificateListResponse DeserializeNginxCertificateListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<NginxCertificateData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NginxCertificateData> array = new List<NginxCertificateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxCertificateData.DeserializeNginxCertificateData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NginxCertificateListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
