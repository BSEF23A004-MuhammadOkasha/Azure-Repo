// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticAnalysis : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Core.Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Core.Optional.IsCollectionDefined(AbnormalTimePeriods))
            {
                writer.WritePropertyName("abnormalTimePeriods"u8);
                writer.WriteStartArray();
                foreach (var item in AbnormalTimePeriods)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(Payload))
            {
                writer.WritePropertyName("payload"u8);
                writer.WriteStartArray();
                foreach (var item in Payload)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(NonCorrelatedDetectors))
            {
                writer.WritePropertyName("nonCorrelatedDetectors"u8);
                writer.WriteStartArray();
                foreach (var item in NonCorrelatedDetectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiagnosticAnalysis DeserializeDiagnosticAnalysis(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<DateTimeOffset> endTime = default;
            Core.Optional<IList<AbnormalTimePeriod>> abnormalTimePeriods = default;
            Core.Optional<IList<AnalysisDetectorEvidences>> payload = default;
            Core.Optional<IList<DetectorDefinition>> nonCorrelatedDetectors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("abnormalTimePeriods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AbnormalTimePeriod> array = new List<AbnormalTimePeriod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AbnormalTimePeriod.DeserializeAbnormalTimePeriod(item));
                            }
                            abnormalTimePeriods = array;
                            continue;
                        }
                        if (property0.NameEquals("payload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AnalysisDetectorEvidences> array = new List<AnalysisDetectorEvidences>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AnalysisDetectorEvidences.DeserializeAnalysisDetectorEvidences(item));
                            }
                            payload = array;
                            continue;
                        }
                        if (property0.NameEquals("nonCorrelatedDetectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DetectorDefinition> array = new List<DetectorDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DetectorDefinition.DeserializeDetectorDefinition(item));
                            }
                            nonCorrelatedDetectors = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiagnosticAnalysis(id, name, type, systemData.Value, Core.Optional.ToNullable(startTime), Core.Optional.ToNullable(endTime), Core.Optional.ToList(abnormalTimePeriods), Core.Optional.ToList(payload), Core.Optional.ToList(nonCorrelatedDetectors), kind.Value);
        }
    }
}
