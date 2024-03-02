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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class KubeletConfig : IUtf8JsonSerializable, IJsonModel<KubeletConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubeletConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubeletConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CpuManagerPolicy != null)
            {
                writer.WritePropertyName("cpuManagerPolicy"u8);
                writer.WriteStringValue(CpuManagerPolicy);
            }
            if (IsCpuCfsQuotaEnabled.HasValue)
            {
                writer.WritePropertyName("cpuCfsQuota"u8);
                writer.WriteBooleanValue(IsCpuCfsQuotaEnabled.Value);
            }
            if (CpuCfsQuotaPeriod != null)
            {
                writer.WritePropertyName("cpuCfsQuotaPeriod"u8);
                writer.WriteStringValue(CpuCfsQuotaPeriod);
            }
            if (ImageGcHighThreshold.HasValue)
            {
                writer.WritePropertyName("imageGcHighThreshold"u8);
                writer.WriteNumberValue(ImageGcHighThreshold.Value);
            }
            if (ImageGcLowThreshold.HasValue)
            {
                writer.WritePropertyName("imageGcLowThreshold"u8);
                writer.WriteNumberValue(ImageGcLowThreshold.Value);
            }
            if (TopologyManagerPolicy != null)
            {
                writer.WritePropertyName("topologyManagerPolicy"u8);
                writer.WriteStringValue(TopologyManagerPolicy);
            }
            if (!(AllowedUnsafeSysctls is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedUnsafeSysctls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnsafeSysctls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (FailStartWithSwapOn.HasValue)
            {
                writer.WritePropertyName("failSwapOn"u8);
                writer.WriteBooleanValue(FailStartWithSwapOn.Value);
            }
            if (ContainerLogMaxSizeInMB.HasValue)
            {
                writer.WritePropertyName("containerLogMaxSizeMB"u8);
                writer.WriteNumberValue(ContainerLogMaxSizeInMB.Value);
            }
            if (ContainerLogMaxFiles.HasValue)
            {
                writer.WritePropertyName("containerLogMaxFiles"u8);
                writer.WriteNumberValue(ContainerLogMaxFiles.Value);
            }
            if (PodMaxPids.HasValue)
            {
                writer.WritePropertyName("podMaxPids"u8);
                writer.WriteNumberValue(PodMaxPids.Value);
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

        KubeletConfig IJsonModel<KubeletConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubeletConfig(document.RootElement, options);
        }

        internal static KubeletConfig DeserializeKubeletConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cpuManagerPolicy = default;
            bool? cpuCfsQuota = default;
            string cpuCfsQuotaPeriod = default;
            int? imageGcHighThreshold = default;
            int? imageGcLowThreshold = default;
            string topologyManagerPolicy = default;
            IList<string> allowedUnsafeSysctls = default;
            bool? failSwapOn = default;
            int? containerLogMaxSizeMB = default;
            int? containerLogMaxFiles = default;
            int? podMaxPids = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuManagerPolicy"u8))
                {
                    cpuManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCfsQuota = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuotaPeriod"u8))
                {
                    cpuCfsQuotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageGcHighThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageGcHighThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("imageGcLowThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageGcLowThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("topologyManagerPolicy"u8))
                {
                    topologyManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedUnsafeSysctls"u8))
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
                    allowedUnsafeSysctls = array;
                    continue;
                }
                if (property.NameEquals("failSwapOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failSwapOn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerLogMaxSizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerLogMaxSizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerLogMaxFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerLogMaxFiles = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("podMaxPids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    podMaxPids = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubeletConfig(
                cpuManagerPolicy,
                cpuCfsQuota,
                cpuCfsQuotaPeriod,
                imageGcHighThreshold,
                imageGcLowThreshold,
                topologyManagerPolicy,
                allowedUnsafeSysctls ?? new ChangeTrackingList<string>(),
                failSwapOn,
                containerLogMaxSizeMB,
                containerLogMaxFiles,
                podMaxPids,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubeletConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{options.Format}' format.");
            }
        }

        KubeletConfig IPersistableModel<KubeletConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubeletConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubeletConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
