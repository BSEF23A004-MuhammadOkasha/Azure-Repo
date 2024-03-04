// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    public partial class PolicyRemediationData : IUtf8JsonSerializable, IJsonModel<PolicyRemediationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyRemediationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyRemediationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyRemediationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyRemediationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyAssignmentId))
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
            }
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsDefined(ResourceDiscoveryMode))
            {
                writer.WritePropertyName("resourceDiscoveryMode"u8);
                writer.WriteStringValue(ResourceDiscoveryMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedOn"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteObjectValue(Filter);
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentStatus))
            {
                writer.WritePropertyName("deploymentStatus"u8);
                writer.WriteObjectValue(DeploymentStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(StatusMessage))
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(ResourceCount))
            {
                writer.WritePropertyName("resourceCount"u8);
                writer.WriteNumberValue(ResourceCount.Value);
            }
            if (Optional.IsDefined(ParallelDeployments))
            {
                writer.WritePropertyName("parallelDeployments"u8);
                writer.WriteNumberValue(ParallelDeployments.Value);
            }
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold"u8);
                writer.WriteObjectValue(FailureThreshold);
            }
            writer.WriteEndObject();
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

        PolicyRemediationData IJsonModel<PolicyRemediationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyRemediationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyRemediationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyRemediationData(document.RootElement, options);
        }

        internal static PolicyRemediationData DeserializePolicyRemediationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier policyAssignmentId = default;
            string policyDefinitionReferenceId = default;
            ResourceDiscoveryMode? resourceDiscoveryMode = default;
            string provisioningState = default;
            DateTimeOffset? createdOn = default;
            DateTimeOffset? lastUpdatedOn = default;
            RemediationFilters filters = default;
            RemediationDeploymentSummary deploymentStatus = default;
            string statusMessage = default;
            string correlationId = default;
            int? resourceCount = default;
            int? parallelDeployments = default;
            RemediationPropertiesFailureThreshold failureThreshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policyAssignmentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyAssignmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionReferenceId"u8))
                        {
                            policyDefinitionReferenceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceDiscoveryMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceDiscoveryMode = new ResourceDiscoveryMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filters = RemediationFilters.DeserializeRemediationFilters(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentStatus = RemediationDeploymentSummary.DeserializeRemediationDeploymentSummary(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("statusMessage"u8))
                        {
                            statusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlationId"u8))
                        {
                            correlationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("parallelDeployments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parallelDeployments = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("failureThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failureThreshold = RemediationPropertiesFailureThreshold.DeserializeRemediationPropertiesFailureThreshold(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyRemediationData(
                id,
                name,
                type,
                systemData,
                policyAssignmentId,
                policyDefinitionReferenceId,
                resourceDiscoveryMode,
                provisioningState,
                createdOn,
                lastUpdatedOn,
                filters,
                deploymentStatus,
                statusMessage,
                correlationId,
                resourceCount,
                parallelDeployments,
                failureThreshold,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyRemediationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyRemediationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyRemediationData)} does not support '{options.Format}' format.");
            }
        }

        PolicyRemediationData IPersistableModel<PolicyRemediationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyRemediationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyRemediationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyRemediationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyRemediationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
