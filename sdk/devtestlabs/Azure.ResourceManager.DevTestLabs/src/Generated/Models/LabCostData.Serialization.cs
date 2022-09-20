// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class LabCostData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetCost))
            {
                writer.WritePropertyName("targetCost");
                writer.WriteObjectValue(TargetCost);
            }
            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode");
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate");
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LabCostData DeserializeLabCostData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<TargetCostProperties> targetCost = default;
            Optional<LabCostSummaryProperties> labCostSummary = default;
            Optional<IReadOnlyList<LabCostDetailsProperties>> labCostDetails = default;
            Optional<IReadOnlyList<LabResourceCostProperties>> resourceCosts = default;
            Optional<string> currencyCode = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> provisioningState = default;
            Optional<string> uniqueIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetCost"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetCost = TargetCostProperties.DeserializeTargetCostProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("labCostSummary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            labCostSummary = LabCostSummaryProperties.DeserializeLabCostSummaryProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("labCostDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LabCostDetailsProperties> array = new List<LabCostDetailsProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LabCostDetailsProperties.DeserializeLabCostDetailsProperties(item));
                            }
                            labCostDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceCosts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LabResourceCostProperties> array = new List<LabResourceCostProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LabResourceCostProperties.DeserializeLabResourceCostProperties(item));
                            }
                            resourceCosts = array;
                            continue;
                        }
                        if (property0.NameEquals("currencyCode"))
                        {
                            currencyCode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"))
                        {
                            uniqueIdentifier = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LabCostData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, targetCost.Value, labCostSummary.Value, Optional.ToList(labCostDetails), Optional.ToList(resourceCosts), currencyCode.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(endDateTime), Optional.ToNullable(createdDate), provisioningState.Value, uniqueIdentifier.Value);
        }
    }
}
