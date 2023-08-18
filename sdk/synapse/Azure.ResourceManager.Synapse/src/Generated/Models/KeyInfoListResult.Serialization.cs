// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class KeyInfoListResult
    {
        internal static KeyInfoListResult DeserializeKeyInfoListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<SynapseKeyData>> value = default;
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
                    List<SynapseKeyData> array = new List<SynapseKeyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseKeyData.DeserializeSynapseKeyData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new KeyInfoListResult(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
