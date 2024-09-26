// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ConfigurationGroupSchemaPropertiesFormat : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupSchemaPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupSchemaPropertiesFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigurationGroupSchemaPropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupSchemaPropertiesFormat)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VersionState))
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(SchemaDefinition))
            {
                writer.WritePropertyName("schemaDefinition"u8);
                writer.WriteStringValue(SchemaDefinition);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ConfigurationGroupSchemaPropertiesFormat IJsonModel<ConfigurationGroupSchemaPropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupSchemaPropertiesFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationGroupSchemaPropertiesFormat(document.RootElement, options);
        }

        internal static ConfigurationGroupSchemaPropertiesFormat DeserializeConfigurationGroupSchemaPropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            VersionState? versionState = default;
            string description = default;
            string schemaDefinition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaDefinition"u8))
                {
                    schemaDefinition = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfigurationGroupSchemaPropertiesFormat(provisioningState, versionState, description, schemaDefinition, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupSchemaPropertiesFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigurationGroupSchemaPropertiesFormat IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationGroupSchemaPropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupSchemaPropertiesFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationGroupSchemaPropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
