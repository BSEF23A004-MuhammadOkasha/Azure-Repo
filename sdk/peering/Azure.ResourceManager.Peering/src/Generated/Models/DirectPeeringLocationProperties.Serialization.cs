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

namespace Azure.ResourceManager.Peering.Models
{
    public partial class DirectPeeringLocationProperties : IUtf8JsonSerializable, IJsonModel<DirectPeeringLocationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectPeeringLocationProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DirectPeeringLocationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PeeringFacilities))
            {
                writer.WritePropertyName("peeringFacilities"u8);
                writer.WriteStartArray();
                foreach (var item in PeeringFacilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BandwidthOffers))
            {
                writer.WritePropertyName("bandwidthOffers"u8);
                writer.WriteStartArray();
                foreach (var item in BandwidthOffers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DirectPeeringLocationProperties IJsonModel<DirectPeeringLocationProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectPeeringLocationProperties(document.RootElement, options);
        }

        internal static DirectPeeringLocationProperties DeserializeDirectPeeringLocationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DirectPeeringFacility>> peeringFacilities = default;
            Optional<IList<PeeringBandwidthOffer>> bandwidthOffers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringFacilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DirectPeeringFacility> array = new List<DirectPeeringFacility>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DirectPeeringFacility.DeserializeDirectPeeringFacility(item));
                    }
                    peeringFacilities = array;
                    continue;
                }
                if (property.NameEquals("bandwidthOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringBandwidthOffer> array = new List<PeeringBandwidthOffer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringBandwidthOffer.DeserializePeeringBandwidthOffer(item));
                    }
                    bandwidthOffers = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DirectPeeringLocationProperties(Optional.ToList(peeringFacilities), Optional.ToList(bandwidthOffers), serializedAdditionalRawData);
        }

        BinaryData IModel<DirectPeeringLocationProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DirectPeeringLocationProperties IModel<DirectPeeringLocationProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDirectPeeringLocationProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DirectPeeringLocationProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
