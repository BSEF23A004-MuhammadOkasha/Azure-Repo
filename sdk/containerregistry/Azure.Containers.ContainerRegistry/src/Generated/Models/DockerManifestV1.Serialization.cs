// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Storage.Models
{
    public partial class DockerManifestV1 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture");
                writer.WriteStringValue(Architecture);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag");
                writer.WriteStringValue(Tag);
            }
            if (Optional.IsCollectionDefined(FsLayers))
            {
                writer.WritePropertyName("fsLayers");
                writer.WriteStartArray();
                foreach (var item in FsLayers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(History))
            {
                writer.WritePropertyName("history");
                writer.WriteStartArray();
                foreach (var item in History)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Signatures))
            {
                writer.WritePropertyName("signatures");
                writer.WriteStartArray();
                foreach (var item in Signatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion");
                writer.WriteNumberValue(SchemaVersion);
            }
            writer.WriteEndObject();
        }

        internal static DockerManifestV1 DeserializeDockerManifestV1(JsonElement element)
        {
            Optional<string> architecture = default;
            Optional<string> name = default;
            Optional<string> tag = default;
            Optional<IList<DockerManifestV1FsLayer>> fsLayers = default;
            Optional<IList<DockerManifestV1History>> history = default;
            Optional<IList<DockerManifestV1ImageSignature>> signatures = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("architecture"))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fsLayers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DockerManifestV1FsLayer> array = new List<DockerManifestV1FsLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DockerManifestV1FsLayer.DeserializeDockerManifestV1FsLayer(item));
                    }
                    fsLayers = array;
                    continue;
                }
                if (property.NameEquals("history"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DockerManifestV1History> array = new List<DockerManifestV1History>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DockerManifestV1History.DeserializeDockerManifestV1History(item));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("signatures"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DockerManifestV1ImageSignature> array = new List<DockerManifestV1ImageSignature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DockerManifestV1ImageSignature.DeserializeDockerManifestV1ImageSignature(item));
                    }
                    signatures = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new DockerManifestV1(schemaVersion, architecture.Value, name.Value, tag.Value, Optional.ToList(fsLayers), Optional.ToList(history), Optional.ToList(signatures));
        }
    }
}
