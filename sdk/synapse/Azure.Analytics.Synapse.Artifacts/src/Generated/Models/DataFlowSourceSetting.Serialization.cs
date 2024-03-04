// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowSourceSettingConverter))]
    public partial class DataFlowSourceSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceName))
            {
                writer.WritePropertyName("sourceName"u8);
                writer.WriteStringValue(SourceName);
            }
            if (Optional.IsDefined(RowLimit))
            {
                writer.WritePropertyName("rowLimit"u8);
                writer.WriteNumberValue(RowLimit.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowSourceSetting DeserializeDataFlowSourceSetting(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceName = default;
            int? rowLimit = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceName"u8))
                {
                    sourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowLimit = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowSourceSetting(sourceName, rowLimit, additionalProperties);
        }

        internal partial class DataFlowSourceSettingConverter : JsonConverter<DataFlowSourceSetting>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowSourceSetting model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowSourceSetting Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowSourceSetting(document.RootElement);
            }
        }
    }
}
