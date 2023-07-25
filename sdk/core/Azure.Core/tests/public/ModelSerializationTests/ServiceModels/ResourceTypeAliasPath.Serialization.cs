// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.Public.ResourceManager.Resources.Models
{
    public partial class ResourceTypeAliasPath : IUtf8JsonSerializable, IJsonModelSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModelSerializable)this).Serialize(writer, ModelSerializerOptions.AzureServiceDefault);

        internal static ResourceTypeAliasPath DeserializeResourceTypeAliasPath(JsonElement element, ModelSerializerOptions? options = default)
        {
            options ??= ModelSerializerOptions.AzureServiceDefault;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<ResourceTypeAliasPattern> pattern = default;
            Optional<ResourceTypeAliasPathMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("pattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pattern = ResourceTypeAliasPattern.DeserializeResourceTypeAliasPattern(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ResourceTypeAliasPathMetadata.DeserializeResourceTypeAliasPathMetadata(property.Value);
                    continue;
                }
            }
            return new ResourceTypeAliasPath(path.Value, Optional.ToList(apiVersions), pattern.Value, metadata.Value);
        }

        void IJsonModelSerializable.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteObjectValue(Pattern);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasPathProperties
        {
            public Optional<string> Path { get; set; }
            public Optional<IReadOnlyList<string>> ApiVersions { get; set; }
            public Optional<ResourceTypeAliasPattern> Pattern { get; set; }
            public Optional<ResourceTypeAliasPathMetadata> Metadata { get; set; }
        }

        object IJsonModelSerializable.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (!reader.TryDeserialize<ResourceTypeAliasPathProperties>(options, SetProperty, out var properties))
                return null;

            return new ResourceTypeAliasPath(properties.Path.Value, Optional.ToList(properties.ApiVersions), properties.Pattern.Value, properties.Metadata.Value);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ResourceTypeAliasPathProperties properties, ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (propertyName.SequenceEqual("path"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Path = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("apiVersions"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ApiVersions = reader.GetList<string>(options);
                return;
            }
            if (propertyName.SequenceEqual("pattern"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Pattern = reader.GetObject<ResourceTypeAliasPattern>(options);
                return;
            }
            if (propertyName.SequenceEqual("metadata"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Metadata = reader.GetObject<ResourceTypeAliasPathMetadata>(options);
                return;
            }
            reader.Skip();
        }

        object IModelSerializable.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPath(doc.RootElement, options);
        }

        BinaryData IModelSerializable.Serialize(ModelSerializerOptions options)
        {
            return ModelSerializerHelper.SerializeToBinaryData((writer) => { Serialize(writer, options); });
        }
    }
}
