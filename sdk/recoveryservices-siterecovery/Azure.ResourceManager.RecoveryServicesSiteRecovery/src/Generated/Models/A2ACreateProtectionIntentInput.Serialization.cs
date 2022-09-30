// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ACreateProtectionIntentInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("fabricObjectId");
            writer.WriteStringValue(FabricObjectId);
            writer.WritePropertyName("primaryLocation");
            writer.WriteStringValue(PrimaryLocation);
            writer.WritePropertyName("recoveryLocation");
            writer.WriteStringValue(RecoveryLocation);
            writer.WritePropertyName("recoverySubscriptionId");
            writer.WriteStringValue(RecoverySubscriptionId);
            writer.WritePropertyName("recoveryAvailabilityType");
            writer.WriteStringValue(RecoveryAvailabilityType.ToString());
            if (Optional.IsDefined(ProtectionProfileCustomInput))
            {
                writer.WritePropertyName("protectionProfileCustomInput");
                writer.WriteObjectValue(ProtectionProfileCustomInput);
            }
            writer.WritePropertyName("recoveryResourceGroupId");
            writer.WriteStringValue(RecoveryResourceGroupId);
            if (Optional.IsDefined(PrimaryStagingStorageAccountCustomInput))
            {
                writer.WritePropertyName("primaryStagingStorageAccountCustomInput");
                writer.WriteObjectValue(PrimaryStagingStorageAccountCustomInput);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetCustomInput))
            {
                writer.WritePropertyName("recoveryAvailabilitySetCustomInput");
                writer.WriteObjectValue(RecoveryAvailabilitySetCustomInput);
            }
            if (Optional.IsDefined(RecoveryVirtualNetworkCustomInput))
            {
                writer.WritePropertyName("recoveryVirtualNetworkCustomInput");
                writer.WriteObjectValue(RecoveryVirtualNetworkCustomInput);
            }
            if (Optional.IsDefined(RecoveryProximityPlacementGroupCustomInput))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupCustomInput");
                writer.WriteObjectValue(RecoveryProximityPlacementGroupCustomInput);
            }
            if (Optional.IsDefined(AutoProtectionOfDataDisk))
            {
                writer.WritePropertyName("autoProtectionOfDataDisk");
                writer.WriteStringValue(AutoProtectionOfDataDisk.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks");
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmManagedDisks))
            {
                writer.WritePropertyName("vmManagedDisks");
                writer.WriteStartArray();
                foreach (var item in VmManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName");
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (Optional.IsDefined(MultiVmGroupId))
            {
                writer.WritePropertyName("multiVmGroupId");
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (Optional.IsDefined(RecoveryBootDiagStorageAccount))
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccount");
                writer.WriteObjectValue(RecoveryBootDiagStorageAccount);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo");
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                writer.WritePropertyName("recoveryAvailabilityZone");
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            if (Optional.IsDefined(AgentAutoUpdateStatus))
            {
                writer.WritePropertyName("agentAutoUpdateStatus");
                writer.WriteStringValue(AgentAutoUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountAuthenticationType))
            {
                writer.WritePropertyName("automationAccountAuthenticationType");
                writer.WriteStringValue(AutomationAccountAuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountArmId))
            {
                writer.WritePropertyName("automationAccountArmId");
                writer.WriteStringValue(AutomationAccountArmId);
            }
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
