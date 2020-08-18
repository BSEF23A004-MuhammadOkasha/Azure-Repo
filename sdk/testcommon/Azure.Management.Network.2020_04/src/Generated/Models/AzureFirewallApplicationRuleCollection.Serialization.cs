// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AzureFirewallApplicationRuleCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteObjectValue(Action);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzureFirewallApplicationRuleCollection DeserializeAzureFirewallApplicationRuleCollection(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<int> priority = default;
            Optional<AzureFirewallRCAction> action = default;
            Optional<IList<AzureFirewallApplicationRule>> rules = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("priority"))
                        {
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("action"))
                        {
                            action = AzureFirewallRCAction.DeserializeAzureFirewallRCAction(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rules"))
                        {
                            List<AzureFirewallApplicationRule> array = new List<AzureFirewallApplicationRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallApplicationRule.DeserializeAzureFirewallApplicationRule(item));
                            }
                            rules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzureFirewallApplicationRuleCollection(id.Value, name.Value, etag.Value, Optional.ToNullable(priority), action.Value, Optional.ToList(rules), Optional.ToNullable(provisioningState));
        }
    }
}
