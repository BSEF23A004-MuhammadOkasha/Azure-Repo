// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    internal partial class ExistingResourceResultSkuEnumeration
    {
        internal static ExistingResourceResultSkuEnumeration DeserializeExistingResourceResultSkuEnumeration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AnalysisExistingSku>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnalysisExistingSku> array = new List<AnalysisExistingSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalysisExistingSku.DeserializeAnalysisExistingSku(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ExistingResourceResultSkuEnumeration(Optional.ToList(value));
        }
    }
}
