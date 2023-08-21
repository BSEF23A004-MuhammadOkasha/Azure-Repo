// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountThrottlingRule
    {
        internal static ServiceAccountThrottlingRule DeserializeServiceAccountThrottlingRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            Optional<float> renewalPeriod = default;
            Optional<float> count = default;
            Optional<float> minCount = default;
            Optional<bool> dynamicThrottlingEnabled = default;
            Optional<IReadOnlyList<ServiceAccountThrottlingMatchPattern>> matchPatterns = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewalPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewalPeriod = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dynamicThrottlingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicThrottlingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchPatterns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountThrottlingMatchPattern> array = new List<ServiceAccountThrottlingMatchPattern>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountThrottlingMatchPattern.DeserializeServiceAccountThrottlingMatchPattern(item));
                    }
                    matchPatterns = array;
                    continue;
                }
            }
            return new ServiceAccountThrottlingRule(key.Value, Optional.ToNullable(renewalPeriod), Optional.ToNullable(count), Optional.ToNullable(minCount), Optional.ToNullable(dynamicThrottlingEnabled), Optional.ToList(matchPatterns));
        }
    }
}
