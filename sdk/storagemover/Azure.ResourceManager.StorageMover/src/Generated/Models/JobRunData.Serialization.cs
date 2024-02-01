// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    public partial class JobRunData : IUtf8JsonSerializable, IJsonModel<JobRunData>, IPersistableModel<JobRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobRunData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobRunData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ScanStatus))
            {
                writer.WritePropertyName("scanStatus"u8);
                writer.WriteStringValue(ScanStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AgentName))
            {
                writer.WritePropertyName("agentName"u8);
                writer.WriteStringValue(AgentName);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentResourceId))
            {
                writer.WritePropertyName("agentResourceId"u8);
                writer.WriteStringValue(AgentResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ExecutionStartOn))
            {
                writer.WritePropertyName("executionStartTime"u8);
                writer.WriteStringValue(ExecutionStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExecutionEndOn))
            {
                writer.WritePropertyName("executionEndTime"u8);
                writer.WriteStringValue(ExecutionEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastStatusUpdate))
            {
                writer.WritePropertyName("lastStatusUpdate"u8);
                writer.WriteStringValue(LastStatusUpdate.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ItemsScanned))
            {
                writer.WritePropertyName("itemsScanned"u8);
                writer.WriteNumberValue(ItemsScanned.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ItemsExcluded))
            {
                writer.WritePropertyName("itemsExcluded"u8);
                writer.WriteNumberValue(ItemsExcluded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ItemsUnsupported))
            {
                writer.WritePropertyName("itemsUnsupported"u8);
                writer.WriteNumberValue(ItemsUnsupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ItemsNoTransferNeeded))
            {
                writer.WritePropertyName("itemsNoTransferNeeded"u8);
                writer.WriteNumberValue(ItemsNoTransferNeeded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ItemsFailed))
            {
                writer.WritePropertyName("itemsFailed"u8);
                writer.WriteNumberValue(ItemsFailed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ItemsTransferred))
            {
                writer.WritePropertyName("itemsTransferred"u8);
                writer.WriteNumberValue(ItemsTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesScanned))
            {
                writer.WritePropertyName("bytesScanned"u8);
                writer.WriteNumberValue(BytesScanned.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesExcluded))
            {
                writer.WritePropertyName("bytesExcluded"u8);
                writer.WriteNumberValue(BytesExcluded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesUnsupported))
            {
                writer.WritePropertyName("bytesUnsupported"u8);
                writer.WriteNumberValue(BytesUnsupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesNoTransferNeeded))
            {
                writer.WritePropertyName("bytesNoTransferNeeded"u8);
                writer.WriteNumberValue(BytesNoTransferNeeded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesFailed))
            {
                writer.WritePropertyName("bytesFailed"u8);
                writer.WriteNumberValue(BytesFailed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesTransferred))
            {
                writer.WritePropertyName("bytesTransferred"u8);
                writer.WriteNumberValue(BytesTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceName))
            {
                writer.WritePropertyName("sourceName"u8);
                writer.WriteStringValue(SourceName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceProperties))
            {
                writer.WritePropertyName("sourceProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(SourceProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(TargetName))
            {
                writer.WritePropertyName("targetName"u8);
                writer.WriteStringValue(TargetName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetProperties))
            {
                writer.WritePropertyName("targetProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TargetProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(TargetProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(JobDefinitionProperties))
            {
                writer.WritePropertyName("jobDefinitionProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(JobDefinitionProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(JobDefinitionProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        JobRunData IJsonModel<JobRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobRunData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobRunData(document.RootElement, options);
        }

        internal static JobRunData DeserializeJobRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<JobRunStatus> status = default;
            Optional<JobRunScanStatus> scanStatus = default;
            Optional<string> agentName = default;
            Optional<ResourceIdentifier> agentResourceId = default;
            Optional<DateTimeOffset> executionStartTime = default;
            Optional<DateTimeOffset> executionEndTime = default;
            Optional<DateTimeOffset> lastStatusUpdate = default;
            Optional<long> itemsScanned = default;
            Optional<long> itemsExcluded = default;
            Optional<long> itemsUnsupported = default;
            Optional<long> itemsNoTransferNeeded = default;
            Optional<long> itemsFailed = default;
            Optional<long> itemsTransferred = default;
            Optional<long> bytesScanned = default;
            Optional<long> bytesExcluded = default;
            Optional<long> bytesUnsupported = default;
            Optional<long> bytesNoTransferNeeded = default;
            Optional<long> bytesFailed = default;
            Optional<long> bytesTransferred = default;
            Optional<string> sourceName = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<BinaryData> sourceProperties = default;
            Optional<string> targetName = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Optional<BinaryData> targetProperties = default;
            Optional<BinaryData> jobDefinitionProperties = default;
            Optional<JobRunError> error = default;
            Optional<StorageMoverProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new JobRunStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scanStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scanStatus = new JobRunScanStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentName"u8))
                        {
                            agentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("executionStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("executionEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastStatusUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastStatusUpdate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("itemsScanned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsScanned = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsExcluded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsExcluded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsUnsupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsUnsupported = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsNoTransferNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsNoTransferNeeded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsFailed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsFailed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesScanned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesScanned = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesExcluded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesExcluded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesUnsupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesUnsupported = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesNoTransferNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesNoTransferNeeded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesFailed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesFailed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sourceName"u8))
                        {
                            sourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("targetName"u8))
                        {
                            targetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("jobDefinitionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobDefinitionProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JobRunError.DeserializeJobRunError(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageMoverProvisioningState(property0.Value.GetString());
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
            return new JobRunData(id, name, type, systemData.Value, Optional.ToNullable(status), Optional.ToNullable(scanStatus), agentName.Value, agentResourceId.Value, Optional.ToNullable(executionStartTime), Optional.ToNullable(executionEndTime), Optional.ToNullable(lastStatusUpdate), Optional.ToNullable(itemsScanned), Optional.ToNullable(itemsExcluded), Optional.ToNullable(itemsUnsupported), Optional.ToNullable(itemsNoTransferNeeded), Optional.ToNullable(itemsFailed), Optional.ToNullable(itemsTransferred), Optional.ToNullable(bytesScanned), Optional.ToNullable(bytesExcluded), Optional.ToNullable(bytesUnsupported), Optional.ToNullable(bytesNoTransferNeeded), Optional.ToNullable(bytesFailed), Optional.ToNullable(bytesTransferred), sourceName.Value, sourceResourceId.Value, sourceProperties.Value, targetName.Value, targetResourceId.Value, targetProperties.Value, jobDefinitionProperties.Value, error.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsDefined(ScanStatus))
            {
                builder.Append("  scanStatus:");
                builder.AppendLine($" '{ScanStatus.ToString()}'");
            }

            if (Optional.IsDefined(AgentName))
            {
                builder.Append("  agentName:");
                builder.AppendLine($" '{AgentName}'");
            }

            if (Optional.IsDefined(AgentResourceId))
            {
                builder.Append("  agentResourceId:");
                builder.AppendLine($" '{AgentResourceId.ToString()}'");
            }

            if (Optional.IsDefined(ExecutionStartOn))
            {
                builder.Append("  executionStartTime:");
                builder.AppendLine($" '{ExecutionStartOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(ExecutionEndOn))
            {
                builder.Append("  executionEndTime:");
                builder.AppendLine($" '{ExecutionEndOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(LastStatusUpdate))
            {
                builder.Append("  lastStatusUpdate:");
                builder.AppendLine($" '{LastStatusUpdate.Value.ToString()}'");
            }

            if (Optional.IsDefined(ItemsScanned))
            {
                builder.Append("  itemsScanned:");
                builder.AppendLine($" '{ItemsScanned.Value.ToString()}'");
            }

            if (Optional.IsDefined(ItemsExcluded))
            {
                builder.Append("  itemsExcluded:");
                builder.AppendLine($" '{ItemsExcluded.Value.ToString()}'");
            }

            if (Optional.IsDefined(ItemsUnsupported))
            {
                builder.Append("  itemsUnsupported:");
                builder.AppendLine($" '{ItemsUnsupported.Value.ToString()}'");
            }

            if (Optional.IsDefined(ItemsNoTransferNeeded))
            {
                builder.Append("  itemsNoTransferNeeded:");
                builder.AppendLine($" '{ItemsNoTransferNeeded.Value.ToString()}'");
            }

            if (Optional.IsDefined(ItemsFailed))
            {
                builder.Append("  itemsFailed:");
                builder.AppendLine($" '{ItemsFailed.Value.ToString()}'");
            }

            if (Optional.IsDefined(ItemsTransferred))
            {
                builder.Append("  itemsTransferred:");
                builder.AppendLine($" '{ItemsTransferred.Value.ToString()}'");
            }

            if (Optional.IsDefined(BytesScanned))
            {
                builder.Append("  bytesScanned:");
                builder.AppendLine($" '{BytesScanned.Value.ToString()}'");
            }

            if (Optional.IsDefined(BytesExcluded))
            {
                builder.Append("  bytesExcluded:");
                builder.AppendLine($" '{BytesExcluded.Value.ToString()}'");
            }

            if (Optional.IsDefined(BytesUnsupported))
            {
                builder.Append("  bytesUnsupported:");
                builder.AppendLine($" '{BytesUnsupported.Value.ToString()}'");
            }

            if (Optional.IsDefined(BytesNoTransferNeeded))
            {
                builder.Append("  bytesNoTransferNeeded:");
                builder.AppendLine($" '{BytesNoTransferNeeded.Value.ToString()}'");
            }

            if (Optional.IsDefined(BytesFailed))
            {
                builder.Append("  bytesFailed:");
                builder.AppendLine($" '{BytesFailed.Value.ToString()}'");
            }

            if (Optional.IsDefined(BytesTransferred))
            {
                builder.Append("  bytesTransferred:");
                builder.AppendLine($" '{BytesTransferred.Value.ToString()}'");
            }

            if (Optional.IsDefined(SourceName))
            {
                builder.Append("  sourceName:");
                builder.AppendLine($" '{SourceName}'");
            }

            if (Optional.IsDefined(SourceResourceId))
            {
                builder.Append("  sourceResourceId:");
                builder.AppendLine($" '{SourceResourceId.ToString()}'");
            }

            if (Optional.IsDefined(SourceProperties))
            {
                builder.Append("  sourceProperties:");
                builder.AppendLine($" '{SourceProperties.ToString()}'");
            }

            if (Optional.IsDefined(TargetName))
            {
                builder.Append("  targetName:");
                builder.AppendLine($" '{TargetName}'");
            }

            if (Optional.IsDefined(TargetResourceId))
            {
                builder.Append("  targetResourceId:");
                builder.AppendLine($" '{TargetResourceId.ToString()}'");
            }

            if (Optional.IsDefined(TargetProperties))
            {
                builder.Append("  targetProperties:");
                builder.AppendLine($" '{TargetProperties.ToString()}'");
            }

            if (Optional.IsDefined(JobDefinitionProperties))
            {
                builder.Append("  jobDefinitionProperties:");
                builder.AppendLine($" '{JobDefinitionProperties.ToString()}'");
            }

            if (Optional.IsDefined(Error))
            {
                builder.Append("  error:");
                AppendChildObject(builder, Error, options, 2);
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<JobRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JobRunData)} does not support '{options.Format}' format.");
            }
        }

        JobRunData IPersistableModel<JobRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobRunData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(JobRunData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
