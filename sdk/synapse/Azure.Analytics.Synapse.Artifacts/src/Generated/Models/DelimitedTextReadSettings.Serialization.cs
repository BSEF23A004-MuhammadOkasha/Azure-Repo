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
    [JsonConverter(typeof(DelimitedTextReadSettingsConverter))]
    public partial class DelimitedTextReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount"u8);
                writer.WriteObjectValue(SkipLineCount);
            }
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties"u8);
                writer.WriteObjectValue(CompressionProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextReadSettings DeserializeDelimitedTextReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> skipLineCount = default;
            Optional<CompressionReadSettings> compressionProperties = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipLineCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipLineCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("compressionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextReadSettings(type, additionalProperties, skipLineCount.Value, compressionProperties.Value);
        }

        internal partial class DelimitedTextReadSettingsConverter : JsonConverter<DelimitedTextReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, DelimitedTextReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DelimitedTextReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDelimitedTextReadSettings(document.RootElement);
            }
        }
    }
}
