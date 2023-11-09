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
    public partial class DirectPeeringFacility : IUtf8JsonSerializable, IJsonModel<DirectPeeringFacility>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectPeeringFacility>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DirectPeeringFacility>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(DirectPeeringType))
            {
                writer.WritePropertyName("directPeeringType"u8);
                writer.WriteStringValue(DirectPeeringType.Value.ToString());
            }
            if (Optional.IsDefined(PeeringDBFacilityId))
            {
                writer.WritePropertyName("peeringDBFacilityId"u8);
                writer.WriteNumberValue(PeeringDBFacilityId.Value);
            }
            if (Optional.IsDefined(PeeringDBFacilityLink))
            {
                writer.WritePropertyName("peeringDBFacilityLink"u8);
                writer.WriteStringValue(PeeringDBFacilityLink);
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

        DirectPeeringFacility IJsonModel<DirectPeeringFacility>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectPeeringFacility(document.RootElement, options);
        }

        internal static DirectPeeringFacility DeserializeDirectPeeringFacility(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> address = default;
            Optional<DirectPeeringType> directPeeringType = default;
            Optional<int> peeringDBFacilityId = default;
            Optional<string> peeringDBFacilityLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("directPeeringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directPeeringType = new DirectPeeringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peeringDBFacilityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringDBFacilityId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peeringDBFacilityLink"u8))
                {
                    peeringDBFacilityLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DirectPeeringFacility(address.Value, Optional.ToNullable(directPeeringType), Optional.ToNullable(peeringDBFacilityId), peeringDBFacilityLink.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<DirectPeeringFacility>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DirectPeeringFacility IModel<DirectPeeringFacility>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDirectPeeringFacility(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DirectPeeringFacility>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
