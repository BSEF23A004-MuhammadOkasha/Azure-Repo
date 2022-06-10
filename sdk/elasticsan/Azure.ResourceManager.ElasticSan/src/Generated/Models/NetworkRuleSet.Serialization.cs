// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal partial class NetworkRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NetworkRuleSet DeserializeNetworkRuleSet(JsonElement element)
        {
            Optional<IList<VirtualNetworkRule>> virtualNetworkRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualNetworkRule> array = new List<VirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworkRule.DeserializeVirtualNetworkRule(item));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
            }
            return new NetworkRuleSet(Optional.ToList(virtualNetworkRules));
        }
    }
}
