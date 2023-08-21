// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class JobBaseResourceArmPaginatedResult
    {
        internal static JobBaseResourceArmPaginatedResult DeserializeJobBaseResourceArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningJobData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningJobData> array = new List<MachineLearningJobData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningJobData.DeserializeMachineLearningJobData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new JobBaseResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
