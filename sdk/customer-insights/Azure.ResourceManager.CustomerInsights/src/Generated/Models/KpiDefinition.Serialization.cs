// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class KpiDefinition
    {
        internal static KpiDefinition DeserializeKpiDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntityType entityType = default;
            string entityTypeName = default;
            Optional<Guid> tenantId = default;
            Optional<string> kpiName = default;
            Optional<IReadOnlyDictionary<string, string>> displayName = default;
            Optional<IReadOnlyDictionary<string, string>> description = default;
            CalculationWindowType calculationWindow = default;
            Optional<string> calculationWindowFieldName = default;
            KpiFunction function = default;
            string expression = default;
            Optional<string> unit = default;
            Optional<string> filter = default;
            Optional<IReadOnlyList<string>> groupBy = default;
            Optional<IReadOnlyList<KpiGroupByMetadata>> groupByMetadata = default;
            Optional<IReadOnlyList<KpiParticipantProfilesMetadata>> participantProfilesMetadata = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<KpiThresholds> thresHolds = default;
            Optional<IReadOnlyList<KpiAlias>> aliases = default;
            Optional<IReadOnlyList<KpiExtract>> extracts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString().ToEntityType();
                    continue;
                }
                if (property.NameEquals("entityTypeName"u8))
                {
                    entityTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("kpiName"u8))
                {
                    kpiName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    displayName = dictionary;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    description = dictionary;
                    continue;
                }
                if (property.NameEquals("calculationWindow"u8))
                {
                    calculationWindow = property.Value.GetString().ToCalculationWindowType();
                    continue;
                }
                if (property.NameEquals("calculationWindowFieldName"u8))
                {
                    calculationWindowFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("function"u8))
                {
                    function = property.Value.GetString().ToKpiFunction();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    groupBy = array;
                    continue;
                }
                if (property.NameEquals("groupByMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiGroupByMetadata> array = new List<KpiGroupByMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiGroupByMetadata.DeserializeKpiGroupByMetadata(item));
                    }
                    groupByMetadata = array;
                    continue;
                }
                if (property.NameEquals("participantProfilesMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiParticipantProfilesMetadata> array = new List<KpiParticipantProfilesMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiParticipantProfilesMetadata.DeserializeKpiParticipantProfilesMetadata(item));
                    }
                    participantProfilesMetadata = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("thresHolds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thresHolds = KpiThresholds.DeserializeKpiThresholds(property.Value);
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiAlias> array = new List<KpiAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiAlias.DeserializeKpiAlias(item));
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("extracts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiExtract> array = new List<KpiExtract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiExtract.DeserializeKpiExtract(item));
                    }
                    extracts = array;
                    continue;
                }
            }
            return new KpiDefinition(entityType, entityTypeName, Optional.ToNullable(tenantId), kpiName.Value, Optional.ToDictionary(displayName), Optional.ToDictionary(description), calculationWindow, calculationWindowFieldName.Value, function, expression, unit.Value, filter.Value, Optional.ToList(groupBy), Optional.ToList(groupByMetadata), Optional.ToList(participantProfilesMetadata), Optional.ToNullable(provisioningState), thresHolds.Value, Optional.ToList(aliases), Optional.ToList(extracts));
        }
    }
}
