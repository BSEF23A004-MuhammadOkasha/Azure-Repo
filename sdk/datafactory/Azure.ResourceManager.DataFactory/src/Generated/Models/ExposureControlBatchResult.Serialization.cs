// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExposureControlBatchResult
    {
        internal static ExposureControlBatchResult DeserializeExposureControlBatchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ExposureControlResult> exposureControlResponses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exposureControlResponses"u8))
                {
                    List<ExposureControlResult> array = new List<ExposureControlResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExposureControlResult.DeserializeExposureControlResult(item));
                    }
                    exposureControlResponses = array;
                    continue;
                }
            }
            return new ExposureControlBatchResult(exposureControlResponses);
        }
    }
}
