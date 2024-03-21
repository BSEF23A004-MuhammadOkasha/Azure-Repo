// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPs : IUtf8JsonSerializable, IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPs>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPs)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicIPs))
            {
                writer.WritePropertyName("publicIPs"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        ManagedClusterLoadBalancerProfileOutboundIPs IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterLoadBalancerProfileOutboundIPs(document.RootElement, options);
        }

        internal static ManagedClusterLoadBalancerProfileOutboundIPs DeserializeManagedClusterLoadBalancerProfileOutboundIPs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WritableSubResource> publicIPs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    publicIPs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterLoadBalancerProfileOutboundIPs(publicIPs ?? new ChangeTrackingList<WritableSubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPs)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterLoadBalancerProfileOutboundIPs IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterLoadBalancerProfileOutboundIPs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
