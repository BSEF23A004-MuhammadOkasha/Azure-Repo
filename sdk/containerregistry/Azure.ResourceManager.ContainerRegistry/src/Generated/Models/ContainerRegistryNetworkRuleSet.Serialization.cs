// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryNetworkRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("defaultAction");
            writer.WriteStringValue(DefaultAction.ToString());
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules");
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryNetworkRuleSet DeserializeContainerRegistryNetworkRuleSet(JsonElement element)
        {
            ContainerRegistryNetworkRuleDefaultAction defaultAction = default;
            Optional<IList<ContainerRegistryIPRule>> ipRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"))
                {
                    defaultAction = new ContainerRegistryNetworkRuleDefaultAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerRegistryIPRule> array = new List<ContainerRegistryIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryIPRule.DeserializeContainerRegistryIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
            }
            return new ContainerRegistryNetworkRuleSet(defaultAction, Optional.ToList(ipRules));
        }
    }
}
