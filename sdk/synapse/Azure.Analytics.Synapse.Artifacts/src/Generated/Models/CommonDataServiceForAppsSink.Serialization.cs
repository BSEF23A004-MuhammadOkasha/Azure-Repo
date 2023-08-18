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
    [JsonConverter(typeof(CommonDataServiceForAppsSinkConverter))]
    public partial class CommonDataServiceForAppsSink : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("writeBehavior"u8);
            writer.WriteStringValue(WriteBehavior.ToString());
            if (Core.Optional.IsDefined(IgnoreNullValues))
            {
                writer.WritePropertyName("ignoreNullValues"u8);
                writer.WriteObjectValue(IgnoreNullValues);
            }
            if (Core.Optional.IsDefined(AlternateKeyName))
            {
                writer.WritePropertyName("alternateKeyName"u8);
                writer.WriteObjectValue(AlternateKeyName);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Core.Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Core.Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Core.Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Core.Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Core.Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static CommonDataServiceForAppsSink DeserializeCommonDataServiceForAppsSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DynamicsSinkWriteBehavior writeBehavior = default;
            Core.Optional<object> ignoreNullValues = default;
            Core.Optional<object> alternateKeyName = default;
            string type = default;
            Core.Optional<object> writeBatchSize = default;
            Core.Optional<object> writeBatchTimeout = default;
            Core.Optional<object> sinkRetryCount = default;
            Core.Optional<object> sinkRetryWait = default;
            Core.Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("writeBehavior"u8))
                {
                    writeBehavior = new DynamicsSinkWriteBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ignoreNullValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreNullValues = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("alternateKeyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alternateKeyName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CommonDataServiceForAppsSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, writeBehavior, ignoreNullValues.Value, alternateKeyName.Value);
        }

        internal partial class CommonDataServiceForAppsSinkConverter : JsonConverter<CommonDataServiceForAppsSink>
        {
            public override void Write(Utf8JsonWriter writer, CommonDataServiceForAppsSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CommonDataServiceForAppsSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCommonDataServiceForAppsSink(document.RootElement);
            }
        }
    }
}
