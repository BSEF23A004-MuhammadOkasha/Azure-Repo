// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class IncidentProperty
    {
        internal static IncidentProperty DeserializeIncidentProperty(JsonElement element)
        {
            AnomalySeverity maxSeverity = default;
            AnomalyIncidentStatus incidentStatus = default;
            Optional<double> valueOfRootNode = default;
            Optional<double?> expectedValueOfRootNode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSeverity"))
                {
                    maxSeverity = new AnomalySeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incidentStatus"))
                {
                    incidentStatus = new AnomalyIncidentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueOfRootNode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueOfRootNode = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("expectedValueOfRootNode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expectedValueOfRootNode = null;
                        continue;
                    }
                    expectedValueOfRootNode = property.Value.GetDouble();
                    continue;
                }
            }
            return new IncidentProperty(maxSeverity, incidentStatus, Optional.ToNullable(valueOfRootNode), Optional.ToNullable(expectedValueOfRootNode));
        }
    }
}
