// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterPoolUpgradeProfileProperties : IUtf8JsonSerializable, IJsonModel<ProvisionedClusterPoolUpgradeProfileProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClusterPoolUpgradeProfileProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProvisionedClusterPoolUpgradeProfileProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterPoolUpgradeProfileProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
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
        }

        ProvisionedClusterPoolUpgradeProfileProperties IJsonModel<ProvisionedClusterPoolUpgradeProfileProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterPoolUpgradeProfileProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClusterPoolUpgradeProfileProperties(document.RootElement, options);
        }

        internal static ProvisionedClusterPoolUpgradeProfileProperties DeserializeProvisionedClusterPoolUpgradeProfileProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kubernetesVersion = default;
            bool? isPreview = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProvisionedClusterPoolUpgradeProfileProperties(kubernetesVersion, isPreview, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterPoolUpgradeProfileProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ProvisionedClusterPoolUpgradeProfileProperties IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProvisionedClusterPoolUpgradeProfileProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterPoolUpgradeProfileProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProvisionedClusterPoolUpgradeProfileProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
