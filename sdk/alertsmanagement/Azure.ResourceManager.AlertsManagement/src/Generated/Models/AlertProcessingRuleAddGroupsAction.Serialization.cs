// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleAddGroupsAction : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("actionGroupIds"u8);
            writer.WriteStartArray();
            foreach (var item in ActionGroupIds)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static AlertProcessingRuleAddGroupsAction DeserializeAlertProcessingRuleAddGroupsAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> actionGroupIds = default;
            AlertProcessingRuleActionType actionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroupIds"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    actionGroupIds = array;
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new AlertProcessingRuleActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AlertProcessingRuleAddGroupsAction(actionType, actionGroupIds);
        }
    }
}
