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
    public partial class PeeringExchangeConnection : IUtf8JsonSerializable, IJsonModel<PeeringExchangeConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringExchangeConnection>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PeeringExchangeConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PeeringExchangeConnection>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PeeringExchangeConnection>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringDBFacilityId))
            {
                writer.WritePropertyName("peeringDBFacilityId"u8);
                writer.WriteNumberValue(PeeringDBFacilityId.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ConnectionState))
                {
                    writer.WritePropertyName("connectionState"u8);
                    writer.WriteStringValue(ConnectionState.Value.ToString());
                }
            }
            if (Optional.IsDefined(BgpSession))
            {
                writer.WritePropertyName("bgpSession"u8);
                writer.WriteObjectValue(BgpSession);
            }
            if (Optional.IsDefined(ConnectionIdentifier))
            {
                writer.WritePropertyName("connectionIdentifier"u8);
                writer.WriteStringValue(ConnectionIdentifier.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ErrorMessage))
                {
                    writer.WritePropertyName("errorMessage"u8);
                    writer.WriteStringValue(ErrorMessage);
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

        PeeringExchangeConnection IJsonModel<PeeringExchangeConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PeeringExchangeConnection)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringExchangeConnection(document.RootElement, options);
        }

        internal static PeeringExchangeConnection DeserializePeeringExchangeConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> peeringDBFacilityId = default;
            Optional<PeeringConnectionState> connectionState = default;
            Optional<PeeringBgpSession> bgpSession = default;
            Optional<Guid> connectionIdentifier = default;
            Optional<string> errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringDBFacilityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringDBFacilityId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new PeeringConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bgpSession"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpSession = PeeringBgpSession.DeserializePeeringBgpSession(property.Value);
                    continue;
                }
                if (property.NameEquals("connectionIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionIdentifier = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeeringExchangeConnection(Optional.ToNullable(peeringDBFacilityId), Optional.ToNullable(connectionState), bgpSession.Value, Optional.ToNullable(connectionIdentifier), errorMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringExchangeConnection>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PeeringExchangeConnection)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PeeringExchangeConnection IPersistableModel<PeeringExchangeConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PeeringExchangeConnection)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePeeringExchangeConnection(document.RootElement, options);
        }

        string IPersistableModel<PeeringExchangeConnection>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
