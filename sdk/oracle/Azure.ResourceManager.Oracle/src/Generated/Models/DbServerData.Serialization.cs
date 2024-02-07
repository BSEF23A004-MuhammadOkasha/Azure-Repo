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
using Azure.ResourceManager.Oracle.Models;

namespace Azure.ResourceManager.Oracle
{
    public partial class DbServerData : IUtf8JsonSerializable, IJsonModel<DbServerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DbServerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DbServerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DbServerData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(Ocid))
            {
                writer.WritePropertyName("ocid"u8);
                writer.WriteStringValue(Ocid);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(CompartmentId))
            {
                writer.WritePropertyName("compartmentId"u8);
                writer.WriteStringValue(CompartmentId);
            }
            if (options.Format != "W" && Optional.IsDefined(ExadataInfrastructureId))
            {
                writer.WritePropertyName("exadataInfrastructureId"u8);
                writer.WriteStringValue(ExadataInfrastructureId);
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleDetails))
            {
                writer.WritePropertyName("lifecycleDetails"u8);
                writer.WriteStringValue(LifecycleDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuCoreCount))
            {
                writer.WritePropertyName("cpuCoreCount"u8);
                writer.WriteNumberValue(CpuCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DbServerPatchingDetails))
            {
                writer.WritePropertyName("dbServerPatchingDetails"u8);
                writer.WriteObjectValue(DbServerPatchingDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxMemoryInGbs))
            {
                writer.WritePropertyName("maxMemoryInGbs"u8);
                writer.WriteNumberValue(MaxMemoryInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DbNodeStorageSizeInGbs))
            {
                writer.WritePropertyName("dbNodeStorageSizeInGbs"u8);
                writer.WriteNumberValue(DbNodeStorageSizeInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VmClusterIds))
            {
                writer.WritePropertyName("vmClusterIds"u8);
                writer.WriteStartArray();
                foreach (var item in VmClusterIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DbNodeIds))
            {
                writer.WritePropertyName("dbNodeIds"u8);
                writer.WriteStartArray();
                foreach (var item in DbNodeIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MaxCpuCount))
            {
                writer.WritePropertyName("maxCpuCount"u8);
                writer.WriteNumberValue(MaxCpuCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AutonomousVmClusterIds))
            {
                writer.WritePropertyName("autonomousVmClusterIds"u8);
                writer.WriteStartArray();
                foreach (var item in AutonomousVmClusterIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AutonomousVirtualMachineIds))
            {
                writer.WritePropertyName("autonomousVirtualMachineIds"u8);
                writer.WriteStartArray();
                foreach (var item in AutonomousVirtualMachineIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(MaxDbNodeStorageInGbs))
            {
                writer.WritePropertyName("maxDbNodeStorageInGbs"u8);
                writer.WriteNumberValue(MaxDbNodeStorageInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemorySizeInGbs))
            {
                writer.WritePropertyName("memorySizeInGbs"u8);
                writer.WriteNumberValue(MemorySizeInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Shape))
            {
                writer.WritePropertyName("shape"u8);
                writer.WriteStringValue(Shape);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
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

        DbServerData IJsonModel<DbServerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DbServerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDbServerData(document.RootElement, options);
        }

        internal static DbServerData DeserializeDbServerData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> ocid = default;
            Optional<string> displayName = default;
            Optional<string> compartmentId = default;
            Optional<string> exadataInfrastructureId = default;
            Optional<string> lifecycleDetails = default;
            Optional<int> cpuCoreCount = default;
            Optional<DbServerPatchingDetails> dbServerPatchingDetails = default;
            Optional<int> maxMemoryInGbs = default;
            Optional<int> dbNodeStorageSizeInGbs = default;
            Optional<IReadOnlyList<string>> vmClusterIds = default;
            Optional<IReadOnlyList<string>> dbNodeIds = default;
            Optional<DbServerProvisioningState> provisioningState = default;
            Optional<int> maxCpuCount = default;
            Optional<IReadOnlyList<string>> autonomousVmClusterIds = default;
            Optional<IReadOnlyList<string>> autonomousVirtualMachineIds = default;
            Optional<int> maxDbNodeStorageInGbs = default;
            Optional<int> memorySizeInGbs = default;
            Optional<string> shape = default;
            Optional<DateTimeOffset> timeCreated = default;
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
                        if (property0.NameEquals("ocid"u8))
                        {
                            ocid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("compartmentId"u8))
                        {
                            compartmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("exadataInfrastructureId"u8))
                        {
                            exadataInfrastructureId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lifecycleDetails"u8))
                        {
                            lifecycleDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cpuCoreCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuCoreCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dbServerPatchingDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dbServerPatchingDetails = DbServerPatchingDetails.DeserializeDbServerPatchingDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maxMemoryInGbs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxMemoryInGbs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dbNodeStorageSizeInGbs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dbNodeStorageSizeInGbs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vmClusterIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            vmClusterIds = array;
                            continue;
                        }
                        if (property0.NameEquals("dbNodeIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbNodeIds = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DbServerProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxCpuCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxCpuCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("autonomousVmClusterIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            autonomousVmClusterIds = array;
                            continue;
                        }
                        if (property0.NameEquals("autonomousVirtualMachineIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            autonomousVirtualMachineIds = array;
                            continue;
                        }
                        if (property0.NameEquals("maxDbNodeStorageInGbs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDbNodeStorageInGbs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("memorySizeInGbs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memorySizeInGbs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("shape"u8))
                        {
                            shape = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
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
            return new DbServerData(id, name, type, systemData.Value, ocid.Value, displayName.Value, compartmentId.Value, exadataInfrastructureId.Value, lifecycleDetails.Value, Optional.ToNullable(cpuCoreCount), dbServerPatchingDetails.Value, Optional.ToNullable(maxMemoryInGbs), Optional.ToNullable(dbNodeStorageSizeInGbs), Optional.ToList(vmClusterIds), Optional.ToList(dbNodeIds), Optional.ToNullable(provisioningState), Optional.ToNullable(maxCpuCount), Optional.ToList(autonomousVmClusterIds), Optional.ToList(autonomousVirtualMachineIds), Optional.ToNullable(maxDbNodeStorageInGbs), Optional.ToNullable(memorySizeInGbs), shape.Value, Optional.ToNullable(timeCreated), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DbServerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DbServerData)} does not support '{options.Format}' format.");
            }
        }

        DbServerData IPersistableModel<DbServerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDbServerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DbServerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DbServerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
