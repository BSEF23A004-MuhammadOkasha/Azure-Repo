// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleId");
            writer.WriteStringValue(RuleId);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions");
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleOverride DeserializeManagedRuleOverride(JsonElement element)
        {
            string ruleId = default;
            Optional<ManagedRuleEnabledState> enabledState = default;
            Optional<RuleMatchActionType> action = default;
            Optional<IList<ManagedRuleExclusion>> exclusions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"))
                {
                    ruleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabledState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledState = new ManagedRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    action = new RuleMatchActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedRuleExclusion> array = new List<ManagedRuleExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleExclusion.DeserializeManagedRuleExclusion(item));
                    }
                    exclusions = array;
                    continue;
                }
            }
            return new ManagedRuleOverride(ruleId, Optional.ToNullable(enabledState), Optional.ToNullable(action), Optional.ToList(exclusions));
        }
    }
}
