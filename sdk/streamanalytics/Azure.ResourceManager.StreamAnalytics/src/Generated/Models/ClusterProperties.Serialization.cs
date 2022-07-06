// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ClusterProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ClusterProperties DeserializeClusterProperties(JsonElement element)
        {
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> clusterId = default;
            Optional<ClusterProvisioningState> provisioningState = default;
            Optional<int> capacityAllocated = default;
            Optional<int> capacityAssigned = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("clusterId"))
                {
                    clusterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ClusterProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacityAllocated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacityAllocated = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("capacityAssigned"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacityAssigned = property.Value.GetInt32();
                    continue;
                }
            }
            return new ClusterProperties(Optional.ToNullable(createdDate), clusterId.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(capacityAllocated), Optional.ToNullable(capacityAssigned));
        }
    }
}
