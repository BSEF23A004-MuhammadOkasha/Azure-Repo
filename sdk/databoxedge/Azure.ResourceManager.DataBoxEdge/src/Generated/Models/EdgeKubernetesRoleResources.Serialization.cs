// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRoleResources : IUtf8JsonSerializable, IJsonModel<EdgeKubernetesRoleResources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeKubernetesRoleResources>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeKubernetesRoleResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRoleResources)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteObjectValue(Storage);
            }
            writer.WritePropertyName("compute"u8);
            writer.WriteObjectValue(Compute);
            if (options.Format != "W" && Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                writer.WriteObjectValue(Network);
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

        EdgeKubernetesRoleResources IJsonModel<EdgeKubernetesRoleResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRoleResources)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesRoleResources(document.RootElement, options);
        }

        internal static EdgeKubernetesRoleResources DeserializeEdgeKubernetesRoleResources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdgeKubernetesRoleStorage storage = default;
            EdgeKubernetesRoleCompute compute = default;
            EdgeKubernetesRoleNetwork network = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storage = EdgeKubernetesRoleStorage.DeserializeEdgeKubernetesRoleStorage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("compute"u8))
                {
                    compute = EdgeKubernetesRoleCompute.DeserializeEdgeKubernetesRoleCompute(property.Value, options);
                    continue;
                }
                if (property.NameEquals("network"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    network = EdgeKubernetesRoleNetwork.DeserializeEdgeKubernetesRoleNetwork(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeKubernetesRoleResources(storage, compute, network, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeKubernetesRoleResources>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRoleResources)} does not support '{options.Format}' format.");
            }
        }

        EdgeKubernetesRoleResources IPersistableModel<EdgeKubernetesRoleResources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeKubernetesRoleResources(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRoleResources)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeKubernetesRoleResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
