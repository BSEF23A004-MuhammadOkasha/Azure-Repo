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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseRestorePointData : IUtf8JsonSerializable, IJsonModel<SynapseRestorePointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseRestorePointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseRestorePointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseRestorePointData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RestorePointType))
            {
                writer.WritePropertyName("restorePointType"u8);
                writer.WriteStringValue(RestorePointType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(EarliestRestoreOn))
            {
                writer.WritePropertyName("earliestRestoreDate"u8);
                writer.WriteStringValue(EarliestRestoreOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RestorePointCreationOn))
            {
                writer.WritePropertyName("restorePointCreationDate"u8);
                writer.WriteStringValue(RestorePointCreationOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RestorePointLabel))
            {
                writer.WritePropertyName("restorePointLabel"u8);
                writer.WriteStringValue(RestorePointLabel);
            }
            writer.WriteEndObject();
        }

        SynapseRestorePointData IJsonModel<SynapseRestorePointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseRestorePointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseRestorePointData(document.RootElement, options);
        }

        internal static SynapseRestorePointData DeserializeSynapseRestorePointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SynapseRestorePointType? restorePointType = default;
            DateTimeOffset? earliestRestoreDate = default;
            DateTimeOffset? restorePointCreationDate = default;
            string restorePointLabel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("restorePointType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointType = property0.Value.GetString().ToSynapseRestorePointType();
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            earliestRestoreDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointCreationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointCreationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointLabel"u8))
                        {
                            restorePointLabel = property0.Value.GetString();
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
            return new SynapseRestorePointData(
                id,
                name,
                type,
                systemData,
                location,
                restorePointType,
                earliestRestoreDate,
                restorePointCreationDate,
                restorePointLabel,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseRestorePointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseRestorePointData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseRestorePointData IPersistableModel<SynapseRestorePointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseRestorePointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseRestorePointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseRestorePointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
