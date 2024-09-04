// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPatchVersionUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterPatchVersionUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPatchVersionUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPatchVersionUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPatchVersionUpgradeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TargetOssVersion))
            {
                writer.WritePropertyName("targetOssVersion"u8);
                writer.WriteStringValue(TargetOssVersion);
            }
            if (Optional.IsDefined(TargetClusterVersion))
            {
                writer.WritePropertyName("targetClusterVersion"u8);
                writer.WriteStringValue(TargetClusterVersion);
            }
            if (Optional.IsDefined(TargetBuildNumber))
            {
                writer.WritePropertyName("targetBuildNumber"u8);
                writer.WriteStringValue(TargetBuildNumber);
            }
            if (Optional.IsDefined(ComponentName))
            {
                writer.WritePropertyName("componentName"u8);
                writer.WriteStringValue(ComponentName);
            }
            writer.WritePropertyName("upgradeType"u8);
            writer.WriteStringValue(UpgradeType.ToString());
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

        ClusterPatchVersionUpgradeProperties IJsonModel<ClusterPatchVersionUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPatchVersionUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPatchVersionUpgradeProperties(document.RootElement, options);
        }

        internal static ClusterPatchVersionUpgradeProperties DeserializeClusterPatchVersionUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetOssVersion = default;
            string targetClusterVersion = default;
            string targetBuildNumber = default;
            string componentName = default;
            ClusterUpgradeType upgradeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetOssVersion"u8))
                {
                    targetOssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetClusterVersion"u8))
                {
                    targetClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBuildNumber"u8))
                {
                    targetBuildNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentName"u8))
                {
                    componentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterUpgradeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterPatchVersionUpgradeProperties(
                upgradeType,
                serializedAdditionalRawData,
                targetOssVersion,
                targetClusterVersion,
                targetBuildNumber,
                componentName);
        }

        BinaryData IPersistableModel<ClusterPatchVersionUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPatchVersionUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPatchVersionUpgradeProperties IPersistableModel<ClusterPatchVersionUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPatchVersionUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPatchVersionUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPatchVersionUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
