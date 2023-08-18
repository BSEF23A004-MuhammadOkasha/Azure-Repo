// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceCertificateListResult
    {
        internal static AppServiceCertificateListResult DeserializeAppServiceCertificateListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AppServiceCertificateData> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AppServiceCertificateData> array = new List<AppServiceCertificateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceCertificateData.DeserializeAppServiceCertificateData(item));
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
            return new AppServiceCertificateListResult(value, nextLink.Value);
        }
    }
}
