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
    public partial class ClusterAvailableUpgradeVersion : IUtf8JsonSerializable, IJsonModel<ClusterAvailableUpgradeVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterAvailableUpgradeVersion>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ClusterAvailableUpgradeVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ControlImpact))
                {
                    writer.WritePropertyName("controlImpact"u8);
                    writer.WriteStringValue(ControlImpact.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ExpectedDuration))
                {
                    writer.WritePropertyName("expectedDuration"u8);
                    writer.WriteStringValue(ExpectedDuration);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ImpactDescription))
                {
                    writer.WritePropertyName("impactDescription"u8);
                    writer.WriteStringValue(ImpactDescription);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SupportExpireOn))
                {
                    writer.WritePropertyName("supportExpiryDate"u8);
                    writer.WriteStringValue(SupportExpireOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TargetClusterVersion))
                {
                    writer.WritePropertyName("targetClusterVersion"u8);
                    writer.WriteStringValue(TargetClusterVersion);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WorkloadImpact))
                {
                    writer.WritePropertyName("workloadImpact"u8);
                    writer.WriteStringValue(WorkloadImpact.Value.ToString());
                }
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

        ClusterAvailableUpgradeVersion IJsonModel<ClusterAvailableUpgradeVersion>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradeVersion)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterAvailableUpgradeVersion(document.RootElement, options);
        }

        internal static ClusterAvailableUpgradeVersion DeserializeClusterAvailableUpgradeVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ControlImpact> controlImpact = default;
            Optional<string> expectedDuration = default;
            Optional<string> impactDescription = default;
            Optional<DateTimeOffset> supportExpiryDate = default;
            Optional<string> targetClusterVersion = default;
            Optional<WorkloadImpact> workloadImpact = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlImpact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlImpact = new ControlImpact(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expectedDuration"u8))
                {
                    expectedDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("impactDescription"u8))
                {
                    impactDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportExpiryDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("targetClusterVersion"u8))
                {
                    targetClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadImpact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadImpact = new WorkloadImpact(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterAvailableUpgradeVersion(Optional.ToNullable(controlImpact), expectedDuration.Value, impactDescription.Value, Optional.ToNullable(supportExpiryDate), targetClusterVersion.Value, Optional.ToNullable(workloadImpact), serializedAdditionalRawData);
        }

        BinaryData IModel<ClusterAvailableUpgradeVersion>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradeVersion)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ClusterAvailableUpgradeVersion IModel<ClusterAvailableUpgradeVersion>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradeVersion)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeClusterAvailableUpgradeVersion(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ClusterAvailableUpgradeVersion>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
