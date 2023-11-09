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
    public partial class DscpQosDefinition : IUtf8JsonSerializable, IJsonModel<DscpQosDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscpQosDefinition>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DscpQosDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Markings))
            {
                writer.WritePropertyName("markings"u8);
                writer.WriteStartArray();
                foreach (var item in Markings)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceIPRanges))
            {
                writer.WritePropertyName("sourceIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourceIPRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationIPRanges))
            {
                writer.WritePropertyName("destinationIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationIPRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourcePortRanges))
            {
                writer.WritePropertyName("sourcePortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPortRanges))
            {
                writer.WritePropertyName("destinationPortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPortRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
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

        DscpQosDefinition IJsonModel<DscpQosDefinition>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscpQosDefinition(document.RootElement, options);
        }

        internal static DscpQosDefinition DeserializeDscpQosDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<int>> markings = default;
            Optional<IList<QosIPRange>> sourceIPRanges = default;
            Optional<IList<QosIPRange>> destinationIPRanges = default;
            Optional<IList<QosPortRange>> sourcePortRanges = default;
            Optional<IList<QosPortRange>> destinationPortRanges = default;
            Optional<ProtocolType> protocol = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("markings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    markings = array;
                    continue;
                }
                if (property.NameEquals("sourceIpRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosIPRange> array = new List<QosIPRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosIPRange.DeserializeQosIPRange(item));
                    }
                    sourceIPRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationIpRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosIPRange> array = new List<QosIPRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosIPRange.DeserializeQosIPRange(item));
                    }
                    destinationIPRanges = array;
                    continue;
                }
                if (property.NameEquals("sourcePortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosPortRange> array = new List<QosPortRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosPortRange.DeserializeQosPortRange(item));
                    }
                    sourcePortRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationPortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosPortRange> array = new List<QosPortRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosPortRange.DeserializeQosPortRange(item));
                    }
                    destinationPortRanges = array;
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new ProtocolType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscpQosDefinition(Optional.ToList(markings), Optional.ToList(sourceIPRanges), Optional.ToList(destinationIPRanges), Optional.ToList(sourcePortRanges), Optional.ToList(destinationPortRanges), Optional.ToNullable(protocol), serializedAdditionalRawData);
        }

        BinaryData IModel<DscpQosDefinition>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DscpQosDefinition IModel<DscpQosDefinition>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDscpQosDefinition(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DscpQosDefinition>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
