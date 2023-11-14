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
    public partial class ConnectionMonitorHttpConfiguration : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorHttpConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorHttpConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ConnectionMonitorHttpConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ConnectionMonitorHttpConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ConnectionMonitorHttpConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToString());
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(RequestHeaders))
            {
                writer.WritePropertyName("requestHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in RequestHeaders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValidStatusCodeRanges))
            {
                writer.WritePropertyName("validStatusCodeRanges"u8);
                writer.WriteStartArray();
                foreach (var item in ValidStatusCodeRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PreferHttps))
            {
                writer.WritePropertyName("preferHTTPS"u8);
                writer.WriteBooleanValue(PreferHttps.Value);
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

        ConnectionMonitorHttpConfiguration IJsonModel<ConnectionMonitorHttpConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorHttpConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorHttpConfiguration(document.RootElement, options);
        }

        internal static ConnectionMonitorHttpConfiguration DeserializeConnectionMonitorHttpConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> port = default;
            Optional<NetworkHttpConfigurationMethod> method = default;
            Optional<string> path = default;
            Optional<IList<NetworkWatcherHttpHeader>> requestHeaders = default;
            Optional<IList<string>> validStatusCodeRanges = default;
            Optional<bool> preferHTTPS = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new NetworkHttpConfigurationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkWatcherHttpHeader> array = new List<NetworkWatcherHttpHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkWatcherHttpHeader.DeserializeNetworkWatcherHttpHeader(item));
                    }
                    requestHeaders = array;
                    continue;
                }
                if (property.NameEquals("validStatusCodeRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    validStatusCodeRanges = array;
                    continue;
                }
                if (property.NameEquals("preferHTTPS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferHTTPS = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionMonitorHttpConfiguration(Optional.ToNullable(port), Optional.ToNullable(method), path.Value, Optional.ToList(requestHeaders), Optional.ToList(validStatusCodeRanges), Optional.ToNullable(preferHTTPS), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionMonitorHttpConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorHttpConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ConnectionMonitorHttpConfiguration IPersistableModel<ConnectionMonitorHttpConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorHttpConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorHttpConfiguration(document.RootElement, options);
        }

        string IPersistableModel<ConnectionMonitorHttpConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
