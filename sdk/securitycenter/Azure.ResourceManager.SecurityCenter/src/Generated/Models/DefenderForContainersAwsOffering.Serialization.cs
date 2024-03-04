// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersAwsOffering : IUtf8JsonSerializable, IJsonModel<DefenderForContainersAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForContainersAwsOffering>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForContainersAwsOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersAwsOffering)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KubernetesService))
            {
                writer.WritePropertyName("kubernetesService"u8);
                writer.WriteObjectValue(KubernetesService);
            }
            if (Optional.IsDefined(KubernetesScubaReader))
            {
                writer.WritePropertyName("kubernetesScubaReader"u8);
                writer.WriteObjectValue(KubernetesScubaReader);
            }
            if (Optional.IsDefined(CloudWatchToKinesis))
            {
                writer.WritePropertyName("cloudWatchToKinesis"u8);
                writer.WriteObjectValue(CloudWatchToKinesis);
            }
            if (Optional.IsDefined(KinesisToS3))
            {
                writer.WritePropertyName("kinesisToS3"u8);
                writer.WriteObjectValue(KinesisToS3);
            }
            if (Optional.IsDefined(ContainerVulnerabilityAssessment))
            {
                writer.WritePropertyName("containerVulnerabilityAssessment"u8);
                writer.WriteObjectValue(ContainerVulnerabilityAssessment);
            }
            if (Optional.IsDefined(ContainerVulnerabilityAssessmentTask))
            {
                writer.WritePropertyName("containerVulnerabilityAssessmentTask"u8);
                writer.WriteObjectValue(ContainerVulnerabilityAssessmentTask);
            }
            if (Optional.IsDefined(IsContainerVulnerabilityAssessmentEnabled))
            {
                writer.WritePropertyName("enableContainerVulnerabilityAssessment"u8);
                writer.WriteBooleanValue(IsContainerVulnerabilityAssessmentEnabled.Value);
            }
            if (Optional.IsDefined(IsAutoProvisioningEnabled))
            {
                writer.WritePropertyName("autoProvisioning"u8);
                writer.WriteBooleanValue(IsAutoProvisioningEnabled.Value);
            }
            if (Optional.IsDefined(KubeAuditRetentionTime))
            {
                writer.WritePropertyName("kubeAuditRetentionTime"u8);
                writer.WriteNumberValue(KubeAuditRetentionTime.Value);
            }
            if (Optional.IsDefined(ScubaExternalId))
            {
                writer.WritePropertyName("scubaExternalId"u8);
                writer.WriteStringValue(ScubaExternalId);
            }
            if (Optional.IsDefined(MdcContainersImageAssessment))
            {
                writer.WritePropertyName("mdcContainersImageAssessment"u8);
                writer.WriteObjectValue(MdcContainersImageAssessment);
            }
            if (Optional.IsDefined(MdcContainersAgentlessDiscoveryK8S))
            {
                writer.WritePropertyName("mdcContainersAgentlessDiscoveryK8s"u8);
                writer.WriteObjectValue(MdcContainersAgentlessDiscoveryK8S);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        DefenderForContainersAwsOffering IJsonModel<DefenderForContainersAwsOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersAwsOffering)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersAwsOffering(document.RootElement, options);
        }

        internal static DefenderForContainersAwsOffering DeserializeDefenderForContainersAwsOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderForContainersAwsOfferingKubernetesService kubernetesService = default;
            DefenderForContainersAwsOfferingKubernetesScubaReader kubernetesScubaReader = default;
            DefenderForContainersAwsOfferingCloudWatchToKinesis cloudWatchToKinesis = default;
            DefenderForContainersAwsOfferingKinesisToS3 kinesisToS3 = default;
            DefenderForContainersAwsOfferingContainerVulnerabilityAssessment containerVulnerabilityAssessment = default;
            DefenderForContainersAwsOfferingContainerVulnerabilityAssessmentTask containerVulnerabilityAssessmentTask = default;
            bool? enableContainerVulnerabilityAssessment = default;
            bool? autoProvisioning = default;
            long? kubeAuditRetentionTime = default;
            string scubaExternalId = default;
            DefenderForContainersAwsOfferingMdcContainersImageAssessment mdcContainersImageAssessment = default;
            DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S = default;
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kubernetesService = DefenderForContainersAwsOfferingKubernetesService.DeserializeDefenderForContainersAwsOfferingKubernetesService(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kubernetesScubaReader"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kubernetesScubaReader = DefenderForContainersAwsOfferingKubernetesScubaReader.DeserializeDefenderForContainersAwsOfferingKubernetesScubaReader(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cloudWatchToKinesis"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudWatchToKinesis = DefenderForContainersAwsOfferingCloudWatchToKinesis.DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kinesisToS3"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kinesisToS3 = DefenderForContainersAwsOfferingKinesisToS3.DeserializeDefenderForContainersAwsOfferingKinesisToS3(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containerVulnerabilityAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerVulnerabilityAssessment = DefenderForContainersAwsOfferingContainerVulnerabilityAssessment.DeserializeDefenderForContainersAwsOfferingContainerVulnerabilityAssessment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containerVulnerabilityAssessmentTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerVulnerabilityAssessmentTask = DefenderForContainersAwsOfferingContainerVulnerabilityAssessmentTask.DeserializeDefenderForContainersAwsOfferingContainerVulnerabilityAssessmentTask(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableContainerVulnerabilityAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableContainerVulnerabilityAssessment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoProvisioning = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kubeAuditRetentionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kubeAuditRetentionTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scubaExternalId"u8))
                {
                    scubaExternalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mdcContainersImageAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersImageAssessment = DefenderForContainersAwsOfferingMdcContainersImageAssessment.DeserializeDefenderForContainersAwsOfferingMdcContainersImageAssessment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdcContainersAgentlessDiscoveryK8s"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersAgentlessDiscoveryK8S = DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S.DeserializeDefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForContainersAwsOffering(
                offeringType,
                description,
                serializedAdditionalRawData,
                kubernetesService,
                kubernetesScubaReader,
                cloudWatchToKinesis,
                kinesisToS3,
                containerVulnerabilityAssessment,
                containerVulnerabilityAssessmentTask,
                enableContainerVulnerabilityAssessment,
                autoProvisioning,
                kubeAuditRetentionTime,
                scubaExternalId,
                mdcContainersImageAssessment,
                mdcContainersAgentlessDiscoveryK8S);
        }

        BinaryData IPersistableModel<DefenderForContainersAwsOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersAwsOffering)} does not support '{options.Format}' format.");
            }
        }

        DefenderForContainersAwsOffering IPersistableModel<DefenderForContainersAwsOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForContainersAwsOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersAwsOffering)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForContainersAwsOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
