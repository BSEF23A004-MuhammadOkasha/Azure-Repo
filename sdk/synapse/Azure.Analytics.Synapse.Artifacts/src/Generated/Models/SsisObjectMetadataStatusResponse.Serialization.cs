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
    [JsonConverter(typeof(SsisObjectMetadataStatusResponseConverter))]
    public partial class SsisObjectMetadataStatusResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStringValue(Properties);
            }
            if (Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            writer.WriteEndObject();
        }

        internal static SsisObjectMetadataStatusResponse DeserializeSsisObjectMetadataStatusResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> name = default;
            Optional<string> properties = default;
            Optional<string> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
            }
            return new SsisObjectMetadataStatusResponse(status.Value, name.Value, properties.Value, error.Value);
        }

        internal partial class SsisObjectMetadataStatusResponseConverter : JsonConverter<SsisObjectMetadataStatusResponse>
        {
            public override void Write(Utf8JsonWriter writer, SsisObjectMetadataStatusResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SsisObjectMetadataStatusResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisObjectMetadataStatusResponse(document.RootElement);
            }
        }
    }
}
