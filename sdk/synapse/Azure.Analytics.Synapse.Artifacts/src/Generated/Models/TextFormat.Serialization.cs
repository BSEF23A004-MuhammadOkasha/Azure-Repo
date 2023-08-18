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
    [JsonConverter(typeof(TextFormatConverter))]
    public partial class TextFormat : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter"u8);
                writer.WriteObjectValue(ColumnDelimiter);
            }
            if (Core.Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter"u8);
                writer.WriteObjectValue(RowDelimiter);
            }
            if (Core.Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar"u8);
                writer.WriteObjectValue(EscapeChar);
            }
            if (Core.Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar"u8);
                writer.WriteObjectValue(QuoteChar);
            }
            if (Core.Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue"u8);
                writer.WriteObjectValue(NullValue);
            }
            if (Core.Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName"u8);
                writer.WriteObjectValue(EncodingName);
            }
            if (Core.Optional.IsDefined(TreatEmptyAsNull))
            {
                writer.WritePropertyName("treatEmptyAsNull"u8);
                writer.WriteObjectValue(TreatEmptyAsNull);
            }
            if (Core.Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount"u8);
                writer.WriteObjectValue(SkipLineCount);
            }
            if (Core.Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader"u8);
                writer.WriteObjectValue(FirstRowAsHeader);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Core.Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                writer.WriteObjectValue(Serializer);
            }
            if (Core.Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                writer.WriteObjectValue(Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TextFormat DeserializeTextFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<object> columnDelimiter = default;
            Core.Optional<object> rowDelimiter = default;
            Core.Optional<object> escapeChar = default;
            Core.Optional<object> quoteChar = default;
            Core.Optional<object> nullValue = default;
            Core.Optional<object> encodingName = default;
            Core.Optional<object> treatEmptyAsNull = default;
            Core.Optional<object> skipLineCount = default;
            Core.Optional<object> firstRowAsHeader = default;
            string type = default;
            Core.Optional<object> serializer = default;
            Core.Optional<object> deserializer = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnDelimiter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnDelimiter = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rowDelimiter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowDelimiter = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("escapeChar"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    escapeChar = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("quoteChar"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quoteChar = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("nullValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nullValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("encodingName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("treatEmptyAsNull"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    treatEmptyAsNull = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("skipLineCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipLineCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("firstRowAsHeader"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstRowAsHeader = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serializer = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("deserializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deserializer = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TextFormat(type, serializer.Value, deserializer.Value, additionalProperties, columnDelimiter.Value, rowDelimiter.Value, escapeChar.Value, quoteChar.Value, nullValue.Value, encodingName.Value, treatEmptyAsNull.Value, skipLineCount.Value, firstRowAsHeader.Value);
        }

        internal partial class TextFormatConverter : JsonConverter<TextFormat>
        {
            public override void Write(Utf8JsonWriter writer, TextFormat model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TextFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTextFormat(document.RootElement);
            }
        }
    }
}
