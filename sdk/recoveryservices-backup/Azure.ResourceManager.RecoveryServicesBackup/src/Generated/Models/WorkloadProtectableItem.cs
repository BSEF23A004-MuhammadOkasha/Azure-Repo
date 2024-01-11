// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for backup item. Workload-specific backup items are derived from this class.
    /// Please note <see cref="WorkloadProtectableItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FileShareProtectableItem"/>, <see cref="VmWorkloadProtectableItem"/>, <see cref="VmWorkloadSapHanaHsrProtectableItem"/>, <see cref="IaasVmProtectableItem"/>, <see cref="IaasClassicComputeVmProtectableItem"/>, <see cref="IaasComputeVmProtectableItem"/>, <see cref="VmWorkloadSapAseSystemProtectableItem"/>, <see cref="VmWorkloadSapHanaDBInstance"/>, <see cref="VmWorkloadSapHanaDatabaseProtectableItem"/>, <see cref="VmWorkloadSapHanaSystemProtectableItem"/>, <see cref="VmWorkloadSqlAvailabilityGroupProtectableItem"/>, <see cref="VmWorkloadSqlDatabaseProtectableItem"/> and <see cref="VmWorkloadSqlInstanceProtectableItem"/>.
    /// </summary>
    public abstract partial class WorkloadProtectableItem
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItem"/>. </summary>
        protected WorkloadProtectableItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItem"/>. </summary>
        /// <param name="backupManagementType"> Type of backup management to backup an item. </param>
        /// <param name="workloadType"> Type of workload for the backup management. </param>
        /// <param name="protectableItemType"> Type of the backup item. </param>
        /// <param name="friendlyName"> Friendly name of the backup item. </param>
        /// <param name="protectionState"> State of the back up item. </param>
        internal WorkloadProtectableItem(string backupManagementType, string workloadType, string protectableItemType, string friendlyName, BackupProtectionStatus? protectionState)
        {
            BackupManagementType = backupManagementType;
            WorkloadType = workloadType;
            ProtectableItemType = protectableItemType;
            FriendlyName = friendlyName;
            ProtectionState = protectionState;
        }

        /// <summary> Type of backup management to backup an item. </summary>
        public string BackupManagementType { get; set; }
        /// <summary> Type of workload for the backup management. </summary>
        public string WorkloadType { get; set; }
        /// <summary> Type of the backup item. </summary>
        internal string ProtectableItemType { get; set; }
        /// <summary> Friendly name of the backup item. </summary>
        public string FriendlyName { get; set; }
        /// <summary> State of the back up item. </summary>
        public BackupProtectionStatus? ProtectionState { get; set; }
    }
}
