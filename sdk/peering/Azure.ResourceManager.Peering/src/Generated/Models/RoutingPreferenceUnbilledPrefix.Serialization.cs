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
    public partial class RoutingPreferenceUnbilledPrefix : IUtf8JsonSerializable, IJsonModel<RoutingPreferenceUnbilledPrefix>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingPreferenceUnbilledPrefix>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RoutingPreferenceUnbilledPrefix>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RoutingPreferenceUnbilledPrefix>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RoutingPreferenceUnbilledPrefix>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Prefix))
                {
                    writer.WritePropertyName("prefix"u8);
                    writer.WriteStringValue(Prefix);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AzureRegion))
                {
                    writer.WritePropertyName("azureRegion"u8);
                    writer.WriteStringValue(AzureRegion.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PeerAsn))
                {
                    writer.WritePropertyName("peerAsn"u8);
                    writer.WriteNumberValue(PeerAsn.Value);
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

        RoutingPreferenceUnbilledPrefix IJsonModel<RoutingPreferenceUnbilledPrefix>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingPreferenceUnbilledPrefix(document.RootElement, options);
        }

        internal static RoutingPreferenceUnbilledPrefix DeserializeRoutingPreferenceUnbilledPrefix(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> prefix = default;
            Optional<AzureLocation> azureRegion = default;
            Optional<int> peerAsn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoutingPreferenceUnbilledPrefix(prefix.Value, Optional.ToNullable(azureRegion), Optional.ToNullable(peerAsn), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingPreferenceUnbilledPrefix>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RoutingPreferenceUnbilledPrefix IPersistableModel<RoutingPreferenceUnbilledPrefix>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRoutingPreferenceUnbilledPrefix(document.RootElement, options);
        }

        string IPersistableModel<RoutingPreferenceUnbilledPrefix>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
