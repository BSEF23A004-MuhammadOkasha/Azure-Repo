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
    public partial class StorageCacheHealth : IUtf8JsonSerializable, IJsonModel<StorageCacheHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheHealth>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StorageCacheHealth>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StorageCacheHealth>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StorageCacheHealth>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(StatusDescription))
            {
                writer.WritePropertyName("statusDescription"u8);
                writer.WriteStringValue(StatusDescription);
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Conditions))
                {
                    writer.WritePropertyName("conditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Conditions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        StorageCacheHealth IJsonModel<StorageCacheHealth>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheHealth(document.RootElement, options);
        }

        internal static StorageCacheHealth DeserializeStorageCacheHealth(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageCacheHealthStateType> state = default;
            Optional<string> statusDescription = default;
            Optional<IReadOnlyList<OutstandingCondition>> conditions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new StorageCacheHealthStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDescription"u8))
                {
                    statusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutstandingCondition> array = new List<OutstandingCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutstandingCondition.DeserializeOutstandingCondition(item));
                    }
                    conditions = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheHealth(Optional.ToNullable(state), statusDescription.Value, Optional.ToList(conditions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheHealth>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageCacheHealth IPersistableModel<StorageCacheHealth>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageCacheHealth)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageCacheHealth(document.RootElement, options);
        }

        string IPersistableModel<StorageCacheHealth>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
