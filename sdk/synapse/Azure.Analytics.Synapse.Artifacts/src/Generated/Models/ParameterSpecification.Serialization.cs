// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ParameterSpecificationConverter))]
    public partial class ParameterSpecification : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Core.Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteObjectValue(DefaultValue);
            }
            writer.WriteEndObject();
        }

        internal static ParameterSpecification DeserializeParameterSpecification(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ParameterType type = default;
            Core.Optional<object> defaultValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = property.Value.GetObject();
                    continue;
                }
            }
            return new ParameterSpecification(type, defaultValue.Value);
        }

        internal partial class ParameterSpecificationConverter : JsonConverter<ParameterSpecification>
        {
            public override void Write(Utf8JsonWriter writer, ParameterSpecification model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ParameterSpecification Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeParameterSpecification(document.RootElement);
            }
        }
    }
}
