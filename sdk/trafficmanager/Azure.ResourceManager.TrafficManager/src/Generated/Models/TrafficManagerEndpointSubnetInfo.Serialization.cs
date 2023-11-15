// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerEndpointSubnetInfo : IUtf8JsonSerializable, IJsonModel<TrafficManagerEndpointSubnetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerEndpointSubnetInfo>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<TrafficManagerEndpointSubnetInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TrafficManagerEndpointSubnetInfo>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TrafficManagerEndpointSubnetInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(First))
            {
                writer.WritePropertyName("first"u8);
                writer.WriteStringValue(First.ToString());
            }
            if (Optional.IsDefined(Last))
            {
                writer.WritePropertyName("last"u8);
                writer.WriteStringValue(Last.ToString());
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteNumberValue(Scope.Value);
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

        TrafficManagerEndpointSubnetInfo IJsonModel<TrafficManagerEndpointSubnetInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointSubnetInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerEndpointSubnetInfo(document.RootElement, options);
        }

        internal static TrafficManagerEndpointSubnetInfo DeserializeTrafficManagerEndpointSubnetInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> first = default;
            Optional<IPAddress> last = default;
            Optional<int> scope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("first"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    first = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("last"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    last = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrafficManagerEndpointSubnetInfo(first.Value, last.Value, Optional.ToNullable(scope), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrafficManagerEndpointSubnetInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointSubnetInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TrafficManagerEndpointSubnetInfo IPersistableModel<TrafficManagerEndpointSubnetInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointSubnetInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTrafficManagerEndpointSubnetInfo(document.RootElement, options);
        }

        string IPersistableModel<TrafficManagerEndpointSubnetInfo>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
