// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    public partial class WorkloadGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(MinResourcePercent))
            {
                writer.WritePropertyName("minResourcePercent");
                writer.WriteNumberValue(MinResourcePercent.Value);
            }
            if (Optional.IsDefined(MaxResourcePercent))
            {
                writer.WritePropertyName("maxResourcePercent");
                writer.WriteNumberValue(MaxResourcePercent.Value);
            }
            if (Optional.IsDefined(MinResourcePercentPerRequest))
            {
                writer.WritePropertyName("minResourcePercentPerRequest");
                writer.WriteNumberValue(MinResourcePercentPerRequest.Value);
            }
            if (Optional.IsDefined(MaxResourcePercentPerRequest))
            {
                writer.WritePropertyName("maxResourcePercentPerRequest");
                writer.WriteNumberValue(MaxResourcePercentPerRequest.Value);
            }
            if (Optional.IsDefined(Importance))
            {
                writer.WritePropertyName("importance");
                writer.WriteStringValue(Importance);
            }
            if (Optional.IsDefined(QueryExecutionTimeout))
            {
                writer.WritePropertyName("queryExecutionTimeout");
                writer.WriteNumberValue(QueryExecutionTimeout.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkloadGroupData DeserializeWorkloadGroupData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<int> minResourcePercent = default;
            Optional<int> maxResourcePercent = default;
            Optional<double> minResourcePercentPerRequest = default;
            Optional<double> maxResourcePercentPerRequest = default;
            Optional<string> importance = default;
            Optional<int> queryExecutionTimeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("minResourcePercent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minResourcePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxResourcePercent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxResourcePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minResourcePercentPerRequest"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minResourcePercentPerRequest = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("maxResourcePercentPerRequest"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxResourcePercentPerRequest = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("importance"))
                        {
                            importance = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryExecutionTimeout"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryExecutionTimeout = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkloadGroupData(id, name, type, Optional.ToNullable(minResourcePercent), Optional.ToNullable(maxResourcePercent), Optional.ToNullable(minResourcePercentPerRequest), Optional.ToNullable(maxResourcePercentPerRequest), importance.Value, Optional.ToNullable(queryExecutionTimeout));
        }
    }
}
