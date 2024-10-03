// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseRecoverableSqlPoolData : IUtf8JsonSerializable, IJsonModel<SynapseRecoverableSqlPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseRecoverableSqlPoolData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseRecoverableSqlPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecoverableSqlPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseRecoverableSqlPoolData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceLevelObjective))
            {
                writer.WritePropertyName("serviceLevelObjective"u8);
                writer.WriteStringValue(ServiceLevelObjective);
            }
            if (options.Format != "W" && Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastAvailableBackupOn))
            {
                writer.WritePropertyName("lastAvailableBackupDate"u8);
                writer.WriteStringValue(LastAvailableBackupOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        SynapseRecoverableSqlPoolData IJsonModel<SynapseRecoverableSqlPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecoverableSqlPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseRecoverableSqlPoolData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseRecoverableSqlPoolData(document.RootElement, options);
        }

        internal static SynapseRecoverableSqlPoolData DeserializeSynapseRecoverableSqlPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string edition = default;
            string serviceLevelObjective = default;
            string elasticPoolName = default;
            DateTimeOffset? lastAvailableBackupDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("edition"u8))
                        {
                            edition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevelObjective"u8))
                        {
                            serviceLevelObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolName"u8))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastAvailableBackupDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastAvailableBackupDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseRecoverableSqlPoolData(
                id,
                name,
                type,
                systemData,
                edition,
                serviceLevelObjective,
                elasticPoolName,
                lastAvailableBackupDate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseRecoverableSqlPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecoverableSqlPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseRecoverableSqlPoolData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseRecoverableSqlPoolData IPersistableModel<SynapseRecoverableSqlPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecoverableSqlPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseRecoverableSqlPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseRecoverableSqlPoolData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseRecoverableSqlPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
