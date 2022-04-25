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
    [JsonConverter(typeof(LinkConnectionSourceDatabaseConverter))]
    public partial class LinkConnectionSourceDatabase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService");
                writer.WriteObjectValue(LinkedService);
            }
            if (Optional.IsDefined(TypeProperties))
            {
                writer.WritePropertyName("typeProperties");
                writer.WriteObjectValue(TypeProperties);
            }
            writer.WriteEndObject();
        }

        internal static LinkConnectionSourceDatabase DeserializeLinkConnectionSourceDatabase(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedService = default;
            Optional<LinkConnectionSourceDatabaseTypeProperties> typeProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    typeProperties = LinkConnectionSourceDatabaseTypeProperties.DeserializeLinkConnectionSourceDatabaseTypeProperties(property.Value);
                    continue;
                }
            }
            return new LinkConnectionSourceDatabase(linkedService.Value, typeProperties.Value);
        }

        internal partial class LinkConnectionSourceDatabaseConverter : JsonConverter<LinkConnectionSourceDatabase>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionSourceDatabase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkConnectionSourceDatabase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionSourceDatabase(document.RootElement);
            }
        }
    }
}
