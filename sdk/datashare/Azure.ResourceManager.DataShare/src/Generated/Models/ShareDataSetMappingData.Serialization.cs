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
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class ShareDataSetMappingData : IUtf8JsonSerializable, IModelJsonSerializable<ShareDataSetMappingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ShareDataSetMappingData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ShareDataSetMappingData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareDataSetMappingData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static ShareDataSetMappingData DeserializeShareDataSetMappingData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AdlsGen2File": return AdlsGen2FileDataSetMapping.DeserializeAdlsGen2FileDataSetMapping(element);
                    case "AdlsGen2FileSystem": return AdlsGen2FileSystemDataSetMapping.DeserializeAdlsGen2FileSystemDataSetMapping(element);
                    case "AdlsGen2Folder": return AdlsGen2FolderDataSetMapping.DeserializeAdlsGen2FolderDataSetMapping(element);
                    case "Blob": return BlobDataSetMapping.DeserializeBlobDataSetMapping(element);
                    case "BlobFolder": return BlobFolderDataSetMapping.DeserializeBlobFolderDataSetMapping(element);
                    case "Container": return BlobContainerDataSetMapping.DeserializeBlobContainerDataSetMapping(element);
                    case "KustoCluster": return KustoClusterDataSetMapping.DeserializeKustoClusterDataSetMapping(element);
                    case "KustoDatabase": return KustoDatabaseDataSetMapping.DeserializeKustoDatabaseDataSetMapping(element);
                    case "KustoTable": return KustoTableDataSetMapping.DeserializeKustoTableDataSetMapping(element);
                    case "SqlDBTable": return SqlDBTableDataSetMapping.DeserializeSqlDBTableDataSetMapping(element);
                    case "SqlDWTable": return SqlDWTableDataSetMapping.DeserializeSqlDWTableDataSetMapping(element);
                    case "SynapseWorkspaceSqlPoolTable": return SynapseWorkspaceSqlPoolTableDataSetMapping.DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataSetMappingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataSetMappingKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ShareDataSetMappingData(id, name, type, systemData.Value, kind, rawData);
        }

        ShareDataSetMappingData IModelJsonSerializable<ShareDataSetMappingData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareDataSetMappingData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeShareDataSetMappingData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ShareDataSetMappingData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareDataSetMappingData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ShareDataSetMappingData IModelSerializable<ShareDataSetMappingData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareDataSetMappingData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeShareDataSetMappingData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ShareDataSetMappingData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ShareDataSetMappingData"/> to convert. </param>
        public static implicit operator RequestContent(ShareDataSetMappingData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ShareDataSetMappingData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ShareDataSetMappingData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeShareDataSetMappingData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
