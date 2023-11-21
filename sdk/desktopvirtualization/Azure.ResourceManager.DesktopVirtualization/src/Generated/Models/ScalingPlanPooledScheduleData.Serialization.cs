// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class ScalingPlanPooledScheduleData : IUtf8JsonSerializable, IJsonModel<ScalingPlanPooledScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScalingPlanPooledScheduleData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScalingPlanPooledScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RampUpStartTime))
            {
                writer.WritePropertyName("rampUpStartTime"u8);
                writer.WriteObjectValue(RampUpStartTime);
            }
            if (Optional.IsDefined(RampUpLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampUpLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(RampUpLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampUpMinimumHostsPct))
            {
                writer.WritePropertyName("rampUpMinimumHostsPct"u8);
                writer.WriteNumberValue(RampUpMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampUpCapacityThresholdPct))
            {
                writer.WritePropertyName("rampUpCapacityThresholdPct"u8);
                writer.WriteNumberValue(RampUpCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(PeakStartTime))
            {
                writer.WritePropertyName("peakStartTime"u8);
                writer.WriteObjectValue(PeakStartTime);
            }
            if (Optional.IsDefined(PeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("peakLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(PeakLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownStartTime))
            {
                writer.WritePropertyName("rampDownStartTime"u8);
                writer.WriteObjectValue(RampDownStartTime);
            }
            if (Optional.IsDefined(RampDownLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampDownLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(RampDownLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownMinimumHostsPct))
            {
                writer.WritePropertyName("rampDownMinimumHostsPct"u8);
                writer.WriteNumberValue(RampDownMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampDownCapacityThresholdPct))
            {
                writer.WritePropertyName("rampDownCapacityThresholdPct"u8);
                writer.WriteNumberValue(RampDownCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(RampDownForceLogoffUsers))
            {
                writer.WritePropertyName("rampDownForceLogoffUsers"u8);
                writer.WriteBooleanValue(RampDownForceLogoffUsers.Value);
            }
            if (Optional.IsDefined(RampDownStopHostsWhen))
            {
                writer.WritePropertyName("rampDownStopHostsWhen"u8);
                writer.WriteStringValue(RampDownStopHostsWhen.Value.ToString());
            }
            if (Optional.IsDefined(RampDownWaitTimeMinutes))
            {
                writer.WritePropertyName("rampDownWaitTimeMinutes"u8);
                writer.WriteNumberValue(RampDownWaitTimeMinutes.Value);
            }
            if (Optional.IsDefined(RampDownNotificationMessage))
            {
                writer.WritePropertyName("rampDownNotificationMessage"u8);
                writer.WriteStringValue(RampDownNotificationMessage);
            }
            if (Optional.IsDefined(OffPeakStartTime))
            {
                writer.WritePropertyName("offPeakStartTime"u8);
                writer.WriteObjectValue(OffPeakStartTime);
            }
            if (Optional.IsDefined(OffPeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("offPeakLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(OffPeakLoadBalancingAlgorithm.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ScalingPlanPooledScheduleData IJsonModel<ScalingPlanPooledScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingPlanPooledScheduleData(document.RootElement, options);
        }

        internal static ScalingPlanPooledScheduleData DeserializeScalingPlanPooledScheduleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<DesktopVirtualizationDayOfWeek>> daysOfWeek = default;
            Optional<ScalingActionTime> rampUpStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> rampUpLoadBalancingAlgorithm = default;
            Optional<int> rampUpMinimumHostsPct = default;
            Optional<int> rampUpCapacityThresholdPct = default;
            Optional<ScalingActionTime> peakStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> peakLoadBalancingAlgorithm = default;
            Optional<ScalingActionTime> rampDownStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> rampDownLoadBalancingAlgorithm = default;
            Optional<int> rampDownMinimumHostsPct = default;
            Optional<int> rampDownCapacityThresholdPct = default;
            Optional<bool> rampDownForceLogoffUsers = default;
            Optional<DesktopVirtualizationStopHostsWhen> rampDownStopHostsWhen = default;
            Optional<int> rampDownWaitTimeMinutes = default;
            Optional<string> rampDownNotificationMessage = default;
            Optional<ScalingActionTime> offPeakStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> offPeakLoadBalancingAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("daysOfWeek"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DesktopVirtualizationDayOfWeek> array = new List<DesktopVirtualizationDayOfWeek>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToDesktopVirtualizationDayOfWeek());
                            }
                            daysOfWeek = array;
                            continue;
                        }
                        if (property0.NameEquals("rampUpStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rampUpLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampUpMinimumHostsPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpMinimumHostsPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampUpCapacityThresholdPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpCapacityThresholdPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peakStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peakLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rampDownLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownMinimumHostsPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownMinimumHostsPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownCapacityThresholdPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownCapacityThresholdPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownForceLogoffUsers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownForceLogoffUsers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("rampDownStopHostsWhen"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownStopHostsWhen = new DesktopVirtualizationStopHostsWhen(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownWaitTimeMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownWaitTimeMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownNotificationMessage"u8))
                        {
                            rampDownNotificationMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offPeakStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("offPeakLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScalingPlanPooledScheduleData(id, name, type, systemData.Value, Optional.ToList(daysOfWeek), rampUpStartTime.Value, Optional.ToNullable(rampUpLoadBalancingAlgorithm), Optional.ToNullable(rampUpMinimumHostsPct), Optional.ToNullable(rampUpCapacityThresholdPct), peakStartTime.Value, Optional.ToNullable(peakLoadBalancingAlgorithm), rampDownStartTime.Value, Optional.ToNullable(rampDownLoadBalancingAlgorithm), Optional.ToNullable(rampDownMinimumHostsPct), Optional.ToNullable(rampDownCapacityThresholdPct), Optional.ToNullable(rampDownForceLogoffUsers), Optional.ToNullable(rampDownStopHostsWhen), Optional.ToNullable(rampDownWaitTimeMinutes), rampDownNotificationMessage.Value, offPeakStartTime.Value, Optional.ToNullable(offPeakLoadBalancingAlgorithm), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScalingPlanPooledScheduleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support '{options.Format}' format.");
            }
        }

        ScalingPlanPooledScheduleData IPersistableModel<ScalingPlanPooledScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScalingPlanPooledScheduleData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScalingPlanPooledScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
