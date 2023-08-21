// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TumblingWindowTriggerConverter))]
    public partial class TumblingWindowTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pipeline"u8);
            writer.WriteObjectValue(Pipeline);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToString());
            writer.WritePropertyName("interval"u8);
            writer.WriteNumberValue(Interval);
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndTime.Value, "O");
            }
            if (Optional.IsDefined(Delay))
            {
                writer.WritePropertyName("delay"u8);
                writer.WriteObjectValue(Delay);
            }
            writer.WritePropertyName("maxConcurrency"u8);
            writer.WriteNumberValue(MaxConcurrency);
            if (Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy"u8);
                writer.WriteObjectValue(RetryPolicy);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TumblingWindowTrigger DeserializeTumblingWindowTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerPipelineReference pipeline = default;
            string type = default;
            Optional<string> description = default;
            Optional<TriggerRuntimeState> runtimeState = default;
            Optional<IList<object>> annotations = default;
            TumblingWindowFrequency frequency = default;
            int interval = default;
            DateTimeOffset startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<object> delay = default;
            int maxConcurrency = default;
            Optional<RetryPolicy> retryPolicy = default;
            Optional<IList<DependencyReference>> dependsOn = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipeline"u8))
                {
                    pipeline = TriggerPipelineReference.DeserializeTriggerPipelineReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new TriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frequency"u8))
                        {
                            frequency = new TumblingWindowFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("interval"u8))
                        {
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
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
                        if (property0.NameEquals("delay"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delay = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrency"u8))
                        {
                            maxConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("retryPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retryPolicy = RetryPolicy.DeserializeRetryPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dependsOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DependencyReference> array = new List<DependencyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DependencyReference.DeserializeDependencyReference(item));
                            }
                            dependsOn = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TumblingWindowTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, pipeline, frequency, interval, startTime, Optional.ToNullable(endTime), delay.Value, maxConcurrency, retryPolicy.Value, Optional.ToList(dependsOn));
        }

        internal partial class TumblingWindowTriggerConverter : JsonConverter<TumblingWindowTrigger>
        {
            public override void Write(Utf8JsonWriter writer, TumblingWindowTrigger model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TumblingWindowTrigger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTumblingWindowTrigger(document.RootElement);
            }
        }
    }
}
