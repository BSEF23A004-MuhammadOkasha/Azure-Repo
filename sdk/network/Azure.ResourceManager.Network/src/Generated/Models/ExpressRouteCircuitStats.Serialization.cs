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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitStats : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitStats>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitStats>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ExpressRouteCircuitStats>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimarybytesIn))
            {
                writer.WritePropertyName("primarybytesIn"u8);
                writer.WriteNumberValue(PrimarybytesIn.Value);
            }
            if (Optional.IsDefined(PrimarybytesOut))
            {
                writer.WritePropertyName("primarybytesOut"u8);
                writer.WriteNumberValue(PrimarybytesOut.Value);
            }
            if (Optional.IsDefined(SecondarybytesIn))
            {
                writer.WritePropertyName("secondarybytesIn"u8);
                writer.WriteNumberValue(SecondarybytesIn.Value);
            }
            if (Optional.IsDefined(SecondarybytesOut))
            {
                writer.WritePropertyName("secondarybytesOut"u8);
                writer.WriteNumberValue(SecondarybytesOut.Value);
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

        ExpressRouteCircuitStats IJsonModel<ExpressRouteCircuitStats>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitStats)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitStats(document.RootElement, options);
        }

        internal static ExpressRouteCircuitStats DeserializeExpressRouteCircuitStats(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> primarybytesIn = default;
            Optional<long> primarybytesOut = default;
            Optional<long> secondarybytesIn = default;
            Optional<long> secondarybytesOut = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarybytesIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primarybytesIn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primarybytesOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primarybytesOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("secondarybytesIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondarybytesIn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("secondarybytesOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondarybytesOut = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteCircuitStats(Optional.ToNullable(primarybytesIn), Optional.ToNullable(primarybytesOut), Optional.ToNullable(secondarybytesIn), Optional.ToNullable(secondarybytesOut), serializedAdditionalRawData);
        }

        BinaryData IModel<ExpressRouteCircuitStats>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitStats)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ExpressRouteCircuitStats IModel<ExpressRouteCircuitStats>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitStats)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeExpressRouteCircuitStats(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ExpressRouteCircuitStats>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
