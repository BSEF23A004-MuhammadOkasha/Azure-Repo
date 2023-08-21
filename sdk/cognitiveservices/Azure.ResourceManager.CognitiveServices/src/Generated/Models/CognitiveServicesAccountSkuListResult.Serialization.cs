// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class CognitiveServicesAccountSkuListResult
    {
        internal static CognitiveServicesAccountSkuListResult DeserializeCognitiveServicesAccountSkuListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<CognitiveServicesAccountSku>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CognitiveServicesAccountSku> array = new List<CognitiveServicesAccountSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesAccountSku.DeserializeCognitiveServicesAccountSku(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CognitiveServicesAccountSkuListResult(Core.Optional.ToList(value));
        }
    }
}
