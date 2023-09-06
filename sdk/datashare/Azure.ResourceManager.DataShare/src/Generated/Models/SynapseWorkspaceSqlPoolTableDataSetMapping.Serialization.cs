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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SynapseWorkspaceSqlPoolTableDataSetMapping : IUtf8JsonSerializable, IModelJsonSerializable<SynapseWorkspaceSqlPoolTableDataSetMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseWorkspaceSqlPoolTableDataSetMapping>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseWorkspaceSqlPoolTableDataSetMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceSqlPoolTableDataSetMapping>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("dataSetId"u8);
            writer.WriteStringValue(DataSetId);
            writer.WritePropertyName("synapseWorkspaceSqlPoolTableResourceId"u8);
            writer.WriteStringValue(SynapseWorkspaceSqlPoolTableResourceId);
            writer.WriteEndObject();
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

        internal static SynapseWorkspaceSqlPoolTableDataSetMapping DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSetMappingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Guid dataSetId = default;
            Optional<DataSetMappingStatus> dataSetMappingStatus = default;
            Optional<DataShareProvisioningState> provisioningState = default;
            ResourceIdentifier synapseWorkspaceSqlPoolTableResourceId = default;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataSetId"u8))
                        {
                            dataSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("dataSetMappingStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSetMappingStatus = new DataSetMappingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataShareProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("synapseWorkspaceSqlPoolTableResourceId"u8))
                        {
                            synapseWorkspaceSqlPoolTableResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseWorkspaceSqlPoolTableDataSetMapping(id, name, type, systemData.Value, kind, dataSetId, Optional.ToNullable(dataSetMappingStatus), Optional.ToNullable(provisioningState), synapseWorkspaceSqlPoolTableResourceId, rawData);
        }

        SynapseWorkspaceSqlPoolTableDataSetMapping IModelJsonSerializable<SynapseWorkspaceSqlPoolTableDataSetMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceSqlPoolTableDataSetMapping>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseWorkspaceSqlPoolTableDataSetMapping>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceSqlPoolTableDataSetMapping>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseWorkspaceSqlPoolTableDataSetMapping IModelSerializable<SynapseWorkspaceSqlPoolTableDataSetMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseWorkspaceSqlPoolTableDataSetMapping>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/> to convert. </param>
        public static implicit operator RequestContent(SynapseWorkspaceSqlPoolTableDataSetMapping model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseWorkspaceSqlPoolTableDataSetMapping(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseWorkspaceSqlPoolTableDataSetMapping(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
