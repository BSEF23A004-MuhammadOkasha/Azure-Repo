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
    [JsonConverter(typeof(JsonFormatConverter))]
    public partial class JsonFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FilePattern))
            {
                writer.WritePropertyName("filePattern");
                writer.WriteStringValue(FilePattern.Value.ToString());
            }
            if (Optional.IsDefined(NestingSeparator))
            {
                writer.WritePropertyName("nestingSeparator");
                writer.WriteObjectValue(NestingSeparator);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName");
                writer.WriteObjectValue(EncodingName);
            }
            if (Optional.IsDefined(JsonNodeReference))
            {
                writer.WritePropertyName("jsonNodeReference");
                writer.WriteObjectValue(JsonNodeReference);
            }
            if (Optional.IsDefined(JsonPathDefinition))
            {
                writer.WritePropertyName("jsonPathDefinition");
                writer.WriteObjectValue(JsonPathDefinition);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer");
                writer.WriteObjectValue(Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer");
                writer.WriteObjectValue(Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static JsonFormat DeserializeJsonFormat(JsonElement element)
        {
            Optional<JsonFormatFilePattern> filePattern = default;
            Optional<object> nestingSeparator = default;
            Optional<object> encodingName = default;
            Optional<object> jsonNodeReference = default;
            Optional<object> jsonPathDefinition = default;
            string type = default;
            Optional<object> serializer = default;
            Optional<object> deserializer = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filePattern = new JsonFormatFilePattern(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nestingSeparator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nestingSeparator = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("encodingName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encodingName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("jsonNodeReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jsonNodeReference = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("jsonPathDefinition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jsonPathDefinition = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serializer = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("deserializer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deserializer = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new JsonFormat(type, serializer.Value, deserializer.Value, additionalProperties, Optional.ToNullable(filePattern), nestingSeparator.Value, encodingName.Value, jsonNodeReference.Value, jsonPathDefinition.Value);
        }

        internal partial class JsonFormatConverter : JsonConverter<JsonFormat>
        {
            public override void Write(Utf8JsonWriter writer, JsonFormat model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override JsonFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeJsonFormat(document.RootElement);
            }
        }
    }
}
