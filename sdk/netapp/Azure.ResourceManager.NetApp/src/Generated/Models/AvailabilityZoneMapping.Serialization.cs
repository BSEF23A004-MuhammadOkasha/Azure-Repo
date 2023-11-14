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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class AvailabilityZoneMapping : IUtf8JsonSerializable, IJsonModel<AvailabilityZoneMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityZoneMapping>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AvailabilityZoneMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AvailabilityZoneMapping>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AvailabilityZoneMapping>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Optional.IsDefined(IsAvailable))
            {
                writer.WritePropertyName("isAvailable"u8);
                writer.WriteBooleanValue(IsAvailable.Value);
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

        AvailabilityZoneMapping IJsonModel<AvailabilityZoneMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityZoneMapping(document.RootElement, options);
        }

        internal static AvailabilityZoneMapping DeserializeAvailabilityZoneMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> availabilityZone = default;
            Optional<bool> isAvailable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityZone"u8))
                {
                    availabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailabilityZoneMapping(availabilityZone.Value, Optional.ToNullable(isAvailable), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityZoneMapping>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMapping)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvailabilityZoneMapping IPersistableModel<AvailabilityZoneMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvailabilityZoneMapping(document.RootElement, options);
        }

        string IPersistableModel<AvailabilityZoneMapping>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
