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
    public partial class PurgeMessageQueueResult : IUtf8JsonSerializable, IJsonModel<PurgeMessageQueueResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurgeMessageQueueResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PurgeMessageQueueResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PurgeMessageQueueResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PurgeMessageQueueResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalMessagesPurged))
            {
                writer.WritePropertyName("totalMessagesPurged"u8);
                writer.WriteNumberValue(TotalMessagesPurged.Value);
            }
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(ModuleId))
            {
                writer.WritePropertyName("moduleId"u8);
                writer.WriteStringValue(ModuleId);
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

        PurgeMessageQueueResult IJsonModel<PurgeMessageQueueResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PurgeMessageQueueResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurgeMessageQueueResult(document.RootElement, options);
        }

        internal static PurgeMessageQueueResult DeserializePurgeMessageQueueResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> totalMessagesPurged = default;
            Optional<string> deviceId = default;
            Optional<string> moduleId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMessagesPurged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMessagesPurged = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PurgeMessageQueueResult(Optional.ToNullable(totalMessagesPurged), deviceId.Value, moduleId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurgeMessageQueueResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PurgeMessageQueueResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PurgeMessageQueueResult IPersistableModel<PurgeMessageQueueResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PurgeMessageQueueResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePurgeMessageQueueResult(document.RootElement, options);
        }

        string IPersistableModel<PurgeMessageQueueResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
