// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestWrapper : IUtf8JsonSerializable, IModelJsonSerializable<ManifestWrapper>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManifestWrapper>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManifestWrapper>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManifestWrapper>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType"u8);
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsCollectionDefined(Manifests))
            {
                writer.WritePropertyName("manifests"u8);
                writer.WriteStartArray();
                foreach (var item in Manifests)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config"u8);
                writer.WriteObjectValue(Config);
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations"u8);
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
            }
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag"u8);
                writer.WriteStringValue(Tag);
            }
            if (Optional.IsCollectionDefined(FsLayers))
            {
                writer.WritePropertyName("fsLayers"u8);
                writer.WriteStartArray();
                foreach (var item in FsLayers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(History))
            {
                writer.WritePropertyName("history"u8);
                writer.WriteStartArray();
                foreach (var item in History)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Signatures))
            {
                writer.WritePropertyName("signatures"u8);
                writer.WriteStartArray();
                foreach (var item in Signatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteNumberValue(SchemaVersion.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ManifestWrapper DeserializeManifestWrapper(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            Optional<IReadOnlyList<ManifestListAttributes>> manifests = default;
            Optional<OciDescriptor> config = default;
            Optional<IReadOnlyList<OciDescriptor>> layers = default;
            Optional<OciAnnotations> annotations = default;
            Optional<string> architecture = default;
            Optional<string> name = default;
            Optional<string> tag = default;
            Optional<IReadOnlyList<FsLayer>> fsLayers = default;
            Optional<IReadOnlyList<History>> history = default;
            Optional<IReadOnlyList<ImageSignature>> signatures = default;
            Optional<int> schemaVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManifestListAttributes> array = new List<ManifestListAttributes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestListAttributes.DeserializeManifestListAttributes(item));
                    }
                    manifests = array;
                    continue;
                }
                if (property.NameEquals("config"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    config = OciDescriptor.DeserializeOciDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OciDescriptor> array = new List<OciDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OciDescriptor.DeserializeOciDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = OciAnnotations.DeserializeOciAnnotations(property.Value);
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fsLayers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FsLayer> array = new List<FsLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FsLayer.DeserializeFsLayer(item));
                    }
                    fsLayers = array;
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<History> array = new List<History>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistry.History.DeserializeHistory(item));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("signatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImageSignature> array = new List<ImageSignature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageSignature.DeserializeImageSignature(item));
                    }
                    signatures = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManifestWrapper(Optional.ToNullable(schemaVersion), mediaType.Value, Optional.ToList(manifests), config.Value, Optional.ToList(layers), annotations.Value, architecture.Value, name.Value, tag.Value, Optional.ToList(fsLayers), Optional.ToList(history), Optional.ToList(signatures), rawData);
        }

        ManifestWrapper IModelJsonSerializable<ManifestWrapper>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManifestWrapper>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManifestWrapper(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManifestWrapper>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManifestWrapper>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManifestWrapper IModelSerializable<ManifestWrapper>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManifestWrapper>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManifestWrapper(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManifestWrapper model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManifestWrapper(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManifestWrapper(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
