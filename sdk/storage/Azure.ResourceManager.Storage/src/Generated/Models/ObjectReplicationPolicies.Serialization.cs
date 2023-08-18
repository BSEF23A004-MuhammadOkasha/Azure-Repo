// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class ObjectReplicationPolicies
    {
        internal static ObjectReplicationPolicies DeserializeObjectReplicationPolicies(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ObjectReplicationPolicyData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObjectReplicationPolicyData> array = new List<ObjectReplicationPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObjectReplicationPolicyData.DeserializeObjectReplicationPolicyData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ObjectReplicationPolicies(Core.Optional.ToList(value));
        }
    }
}
