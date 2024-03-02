// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPPrefixes : IUtf8JsonSerializable, IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPPrefixes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(PublicIPPrefixes is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("publicIPPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPPrefixes)
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

        ManagedClusterLoadBalancerProfileOutboundIPPrefixes IJsonModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPPrefixes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(document.RootElement, options);
        }

        internal static ManagedClusterLoadBalancerProfileOutboundIPPrefixes DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WritableSubResource> publicIPPrefixes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPPrefixes"u8))
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
                    publicIPPrefixes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterLoadBalancerProfileOutboundIPPrefixes(publicIPPrefixes ?? new ChangeTrackingList<WritableSubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPPrefixes)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterLoadBalancerProfileOutboundIPPrefixes IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterLoadBalancerProfileOutboundIPPrefixes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
