// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PlanRequesterDetails
    {
        internal static PlanRequesterDetails DeserializePlanRequesterDetails(JsonElement element)
        {
            Optional<string> planId = default;
            Optional<string> planDisplayName = default;
            Optional<IReadOnlyList<PlanRequesterInfo>> requesters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("planId"))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requesters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PlanRequesterInfo> array = new List<PlanRequesterInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlanRequesterInfo.DeserializePlanRequesterInfo(item));
                    }
                    requesters = array;
                    continue;
                }
            }
            return new PlanRequesterDetails(planId.Value, planDisplayName.Value, Optional.ToList(requesters));
        }
    }
}
