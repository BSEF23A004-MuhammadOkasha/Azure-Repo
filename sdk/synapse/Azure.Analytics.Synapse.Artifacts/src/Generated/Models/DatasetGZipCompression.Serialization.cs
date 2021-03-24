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
    [JsonConverter(typeof(DatasetGZipCompressionConverter))]
    public partial class DatasetGZipCompression : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level.Value.ToString());
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DatasetGZipCompression DeserializeDatasetGZipCompression(JsonElement element)
        {
            Optional<DatasetCompressionLevel> level = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    level = new DatasetCompressionLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DatasetGZipCompression(type, additionalProperties, Optional.ToNullable(level));
        }

        internal partial class DatasetGZipCompressionConverter : JsonConverter<DatasetGZipCompression>
        {
            public override void Write(Utf8JsonWriter writer, DatasetGZipCompression model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DatasetGZipCompression Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetGZipCompression(document.RootElement);
            }
        }
    }
}
