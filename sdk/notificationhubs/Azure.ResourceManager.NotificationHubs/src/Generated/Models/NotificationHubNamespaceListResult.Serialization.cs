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
using Azure.ResourceManager.NotificationHubs;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    internal partial class NotificationHubNamespaceListResult : IUtf8JsonSerializable, IJsonModel<NotificationHubNamespaceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubNamespaceListResult>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NotificationHubNamespaceListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        NotificationHubNamespaceListResult IJsonModel<NotificationHubNamespaceListResult>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NotificationHubNamespaceListResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubNamespaceListResult(document.RootElement, options);
        }

        internal static NotificationHubNamespaceListResult DeserializeNotificationHubNamespaceListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NotificationHubNamespaceData>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationHubNamespaceData> array = new List<NotificationHubNamespaceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationHubNamespaceData.DeserializeNotificationHubNamespaceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NotificationHubNamespaceListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<NotificationHubNamespaceListResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NotificationHubNamespaceListResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NotificationHubNamespaceListResult IModel<NotificationHubNamespaceListResult>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NotificationHubNamespaceListResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNotificationHubNamespaceListResult(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NotificationHubNamespaceListResult>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
