// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtEnableMigrationContent : IUtf8JsonSerializable, IJsonModel<VMwareCbtEnableMigrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtEnableMigrationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtEnableMigrationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtEnableMigrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtEnableMigrationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("vmwareMachineId"u8);
            writer.WriteStringValue(VMwareMachineId);
            writer.WritePropertyName("disksToInclude"u8);
            writer.WriteStartArray();
            foreach (var item in DisksToInclude)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (LicenseType.HasValue)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (SqlServerLicenseType.HasValue)
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (PerformSqlBulkRegistration != null)
            {
                writer.WritePropertyName("performSqlBulkRegistration"u8);
                writer.WriteStringValue(PerformSqlBulkRegistration);
            }
            writer.WritePropertyName("dataMoverRunAsAccountId"u8);
            writer.WriteStringValue(DataMoverRunAsAccountId);
            writer.WritePropertyName("snapshotRunAsAccountId"u8);
            writer.WriteStringValue(SnapshotRunAsAccountId);
            if (TargetVmName != null)
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            if (TargetVmSize != null)
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            writer.WritePropertyName("targetResourceGroupId"u8);
            writer.WriteStringValue(TargetResourceGroupId);
            writer.WritePropertyName("targetNetworkId"u8);
            writer.WriteStringValue(TargetNetworkId);
            if (TestNetworkId != null)
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (TargetSubnetName != null)
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (TestSubnetName != null)
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (TargetAvailabilitySetId != null)
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (TargetAvailabilityZone != null)
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (TargetProximityPlacementGroupId != null)
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (ConfidentialVmKeyVaultId != null)
            {
                writer.WritePropertyName("confidentialVmKeyVaultId"u8);
                writer.WriteStringValue(ConfidentialVmKeyVaultId);
            }
            if (TargetVmSecurityProfile != null)
            {
                writer.WritePropertyName("targetVmSecurityProfile"u8);
                writer.WriteObjectValue(TargetVmSecurityProfile);
            }
            if (TargetBootDiagnosticsStorageAccountId != null)
            {
                writer.WritePropertyName("targetBootDiagnosticsStorageAccountId"u8);
                writer.WriteStringValue(TargetBootDiagnosticsStorageAccountId);
            }
            if (PerformAutoResync != null)
            {
                writer.WritePropertyName("performAutoResync"u8);
                writer.WriteStringValue(PerformAutoResync);
            }
            if (!(TargetVmTags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(SeedDiskTags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("seedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetDiskTags is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("targetDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetNicTags is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareCbtEnableMigrationContent IJsonModel<VMwareCbtEnableMigrationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtEnableMigrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtEnableMigrationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtEnableMigrationContent(document.RootElement, options);
        }

        internal static VMwareCbtEnableMigrationContent DeserializeVMwareCbtEnableMigrationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareMachineId = default;
            IList<VMwareCbtDiskContent> disksToInclude = default;
            Optional<SiteRecoveryLicenseType> licenseType = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            Optional<string> performSqlBulkRegistration = default;
            ResourceIdentifier dataMoverRunAsAccountId = default;
            ResourceIdentifier snapshotRunAsAccountId = default;
            Optional<string> targetVmName = default;
            Optional<string> targetVmSize = default;
            ResourceIdentifier targetResourceGroupId = default;
            ResourceIdentifier targetNetworkId = default;
            Optional<ResourceIdentifier> testNetworkId = default;
            Optional<string> targetSubnetName = default;
            Optional<string> testSubnetName = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<ResourceIdentifier> confidentialVmKeyVaultId = default;
            Optional<VMwareCbtSecurityProfileProperties> targetVmSecurityProfile = default;
            Optional<ResourceIdentifier> targetBootDiagnosticsStorageAccountId = default;
            Optional<string> performAutoResync = default;
            IDictionary<string, string> targetVmTags = default;
            IDictionary<string, string> seedDiskTags = default;
            IDictionary<string, string> targetDiskTags = default;
            IDictionary<string, string> targetNicTags = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareMachineId"u8))
                {
                    vmwareMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    List<VMwareCbtDiskContent> array = new List<VMwareCbtDiskContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtDiskContent.DeserializeVMwareCbtDiskContent(item, options));
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performSqlBulkRegistration"u8))
                {
                    performSqlBulkRegistration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataMoverRunAsAccountId"u8))
                {
                    dataMoverRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("snapshotRunAsAccountId"u8))
                {
                    snapshotRunAsAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("confidentialVmKeyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidentialVmKeyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSecurityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVmSecurityProfile = VMwareCbtSecurityProfileProperties.DeserializeVMwareCbtSecurityProfileProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetBootDiagnosticsStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBootDiagnosticsStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performAutoResync"u8))
                {
                    performAutoResync = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("seedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    seedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtEnableMigrationContent(instanceType, serializedAdditionalRawData, vmwareMachineId, disksToInclude, Optional.ToNullable(licenseType), Optional.ToNullable(sqlServerLicenseType), performSqlBulkRegistration.Value, dataMoverRunAsAccountId, snapshotRunAsAccountId, targetVmName.Value, targetVmSize.Value, targetResourceGroupId, targetNetworkId, testNetworkId.Value, targetSubnetName.Value, testSubnetName.Value, targetAvailabilitySetId.Value, targetAvailabilityZone.Value, targetProximityPlacementGroupId.Value, confidentialVmKeyVaultId.Value, targetVmSecurityProfile.Value, targetBootDiagnosticsStorageAccountId.Value, performAutoResync.Value, targetVmTags ?? new ChangeTrackingDictionary<string, string>(), seedDiskTags ?? new ChangeTrackingDictionary<string, string>(), targetDiskTags ?? new ChangeTrackingDictionary<string, string>(), targetNicTags ?? new ChangeTrackingDictionary<string, string>());
        }

        BinaryData IPersistableModel<VMwareCbtEnableMigrationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtEnableMigrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtEnableMigrationContent)} does not support '{options.Format}' format.");
            }
        }

        VMwareCbtEnableMigrationContent IPersistableModel<VMwareCbtEnableMigrationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtEnableMigrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtEnableMigrationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtEnableMigrationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtEnableMigrationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
