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

namespace Azure.IoT.Hub.Service.Models
{
    public partial class BulkRegistryOperationResponse : IUtf8JsonSerializable, IJsonModel<BulkRegistryOperationResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BulkRegistryOperationResponse>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BulkRegistryOperationResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BulkRegistryOperationResponse>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BulkRegistryOperationResponse>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsSuccessful))
            {
                writer.WritePropertyName("isSuccessful"u8);
                writer.WriteBooleanValue(IsSuccessful.Value);
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings"u8);
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BulkRegistryOperationResponse IJsonModel<BulkRegistryOperationResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BulkRegistryOperationResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBulkRegistryOperationResponse(document.RootElement, options);
        }

        internal static BulkRegistryOperationResponse DeserializeBulkRegistryOperationResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isSuccessful = default;
            Optional<IReadOnlyList<DeviceRegistryOperationError>> errors = default;
            Optional<IReadOnlyList<DeviceRegistryOperationWarning>> warnings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSuccessful"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSuccessful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryOperationError> array = new List<DeviceRegistryOperationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryOperationError.DeserializeDeviceRegistryOperationError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryOperationWarning> array = new List<DeviceRegistryOperationWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryOperationWarning.DeserializeDeviceRegistryOperationWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BulkRegistryOperationResponse(Optional.ToNullable(isSuccessful), Optional.ToList(errors), Optional.ToList(warnings), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BulkRegistryOperationResponse>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BulkRegistryOperationResponse)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BulkRegistryOperationResponse IPersistableModel<BulkRegistryOperationResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BulkRegistryOperationResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBulkRegistryOperationResponse(document.RootElement, options);
        }

        string IPersistableModel<BulkRegistryOperationResponse>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
