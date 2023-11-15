// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemPropertiesMaintenanceWindow : IUtf8JsonSerializable, IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AmlFileSystemPropertiesMaintenanceWindow>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            if (Optional.IsDefined(TimeOfDayUTC))
            {
                writer.WritePropertyName("timeOfDayUTC"u8);
                writer.WriteStringValue(TimeOfDayUTC);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        AmlFileSystemPropertiesMaintenanceWindow IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesMaintenanceWindow)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemPropertiesMaintenanceWindow(document.RootElement, options);
        }

        internal static AmlFileSystemPropertiesMaintenanceWindow DeserializeAmlFileSystemPropertiesMaintenanceWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MaintenanceDayOfWeekType> dayOfWeek = default;
            Optional<string> timeOfDayUTC = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToMaintenanceDayOfWeekType();
                    continue;
                }
                if (property.NameEquals("timeOfDayUTC"u8))
                {
                    timeOfDayUTC = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemPropertiesMaintenanceWindow(Optional.ToNullable(dayOfWeek), timeOfDayUTC.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemPropertiesMaintenanceWindow>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesMaintenanceWindow)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AmlFileSystemPropertiesMaintenanceWindow IPersistableModel<AmlFileSystemPropertiesMaintenanceWindow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesMaintenanceWindow)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAmlFileSystemPropertiesMaintenanceWindow(document.RootElement, options);
        }

        string IPersistableModel<AmlFileSystemPropertiesMaintenanceWindow>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
