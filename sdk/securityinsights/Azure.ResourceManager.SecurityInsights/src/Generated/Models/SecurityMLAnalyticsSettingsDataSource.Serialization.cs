// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityMLAnalyticsSettingsDataSource : IUtf8JsonSerializable, IJsonModel<SecurityMLAnalyticsSettingsDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityMLAnalyticsSettingsDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityMLAnalyticsSettingsDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityMLAnalyticsSettingsDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecurityMLAnalyticsSettingsDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectorId))
            {
                writer.WritePropertyName("connectorId"u8);
                writer.WriteStringValue(ConnectorId);
            }
            if (Optional.IsCollectionDefined(DataTypes))
            {
                writer.WritePropertyName("dataTypes"u8);
                writer.WriteStartArray();
                foreach (var item in DataTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
            writer.WriteEndObject();
        }

        SecurityMLAnalyticsSettingsDataSource IJsonModel<SecurityMLAnalyticsSettingsDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityMLAnalyticsSettingsDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecurityMLAnalyticsSettingsDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityMLAnalyticsSettingsDataSource(document.RootElement, options);
        }

        internal static SecurityMLAnalyticsSettingsDataSource DeserializeSecurityMLAnalyticsSettingsDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> connectorId = default;
            Optional<IList<string>> dataTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectorId"u8))
                {
                    connectorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTypes"u8))
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
                    dataTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityMLAnalyticsSettingsDataSource(connectorId.Value, Optional.ToList(dataTypes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityMLAnalyticsSettingsDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityMLAnalyticsSettingsDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SecurityMLAnalyticsSettingsDataSource)} does not support '{options.Format}' format.");
            }
        }

        SecurityMLAnalyticsSettingsDataSource IPersistableModel<SecurityMLAnalyticsSettingsDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityMLAnalyticsSettingsDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityMLAnalyticsSettingsDataSource(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SecurityMLAnalyticsSettingsDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityMLAnalyticsSettingsDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
