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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ServiceLoadBalancerBgpPeer : IUtf8JsonSerializable, IJsonModel<ServiceLoadBalancerBgpPeer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceLoadBalancerBgpPeer>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ServiceLoadBalancerBgpPeer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BfdEnabled))
            {
                writer.WritePropertyName("bfdEnabled"u8);
                writer.WriteStringValue(BfdEnabled.Value.ToString());
            }
            if (Optional.IsDefined(BgpMultiHop))
            {
                writer.WritePropertyName("bgpMultiHop"u8);
                writer.WriteStringValue(BgpMultiHop.Value.ToString());
            }
            if (Optional.IsDefined(HoldTime))
            {
                writer.WritePropertyName("holdTime"u8);
                writer.WriteStringValue(HoldTime);
            }
            if (Optional.IsDefined(KeepAliveTime))
            {
                writer.WritePropertyName("keepAliveTime"u8);
                writer.WriteStringValue(KeepAliveTime);
            }
            if (Optional.IsDefined(MyAsn))
            {
                writer.WritePropertyName("myAsn"u8);
                writer.WriteNumberValue(MyAsn.Value);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            writer.WritePropertyName("peerAddress"u8);
            writer.WriteStringValue(PeerAddress);
            writer.WritePropertyName("peerAsn"u8);
            writer.WriteNumberValue(PeerAsn);
            if (Optional.IsDefined(PeerPort))
            {
                writer.WritePropertyName("peerPort"u8);
                writer.WriteNumberValue(PeerPort.Value);
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

        ServiceLoadBalancerBgpPeer IJsonModel<ServiceLoadBalancerBgpPeer>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceLoadBalancerBgpPeer(document.RootElement, options);
        }

        internal static ServiceLoadBalancerBgpPeer DeserializeServiceLoadBalancerBgpPeer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BfdEnabled> bfdEnabled = default;
            Optional<BgpMultiHop> bgpMultiHop = default;
            Optional<string> holdTime = default;
            Optional<string> keepAliveTime = default;
            Optional<long> myAsn = default;
            string name = default;
            Optional<string> password = default;
            string peerAddress = default;
            long peerAsn = default;
            Optional<long> peerPort = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdEnabled = new BfdEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bgpMultiHop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpMultiHop = new BgpMultiHop(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("holdTime"u8))
                {
                    holdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keepAliveTime"u8))
                {
                    keepAliveTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("myAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    myAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerAddress"u8))
                {
                    peerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerPort = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceLoadBalancerBgpPeer(Optional.ToNullable(bfdEnabled), Optional.ToNullable(bgpMultiHop), holdTime.Value, keepAliveTime.Value, Optional.ToNullable(myAsn), name, password.Value, peerAddress, peerAsn, Optional.ToNullable(peerPort), serializedAdditionalRawData);
        }

        BinaryData IModel<ServiceLoadBalancerBgpPeer>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServiceLoadBalancerBgpPeer IModel<ServiceLoadBalancerBgpPeer>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceLoadBalancerBgpPeer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServiceLoadBalancerBgpPeer(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ServiceLoadBalancerBgpPeer>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
