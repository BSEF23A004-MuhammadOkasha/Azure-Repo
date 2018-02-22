// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A2A protected managed disk details.
    /// </summary>
    public partial class A2AProtectedManagedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AProtectedManagedDiskDetails
        /// class.
        /// </summary>
        public A2AProtectedManagedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AProtectedManagedDiskDetails
        /// class.
        /// </summary>
        /// <param name="diskId">The managed disk Arm id.</param>
        /// <param name="recoveryResourceGroupId">The recovery disk resource
        /// group Arm Id.</param>
        /// <param name="recoveryTargetDiskId">Recovery target disk Arm
        /// Id.</param>
        /// <param name="recoveryReplicaDiskId">Recovery replica disk Arm
        /// Id.</param>
        /// <param name="recoveryReplicaDiskAccountType">The replica disk type.
        /// Its an optional value and will be same as source disk type if not
        /// user provided.</param>
        /// <param name="recoveryTargetDiskAccountType">The target disk type
        /// after failover. Its an optional value and will be same as source
        /// disk type if not user provided.</param>
        /// <param name="diskName">The disk name.</param>
        /// <param name="diskCapacityInBytes">The disk capacity in
        /// bytes.</param>
        /// <param name="primaryStagingAzureStorageAccountId">The primary
        /// staging storage account.</param>
        /// <param name="diskType">The type of disk.</param>
        /// <param name="resyncRequired">A value indicating whether resync is
        /// required for this disk.</param>
        /// <param name="monitoringPercentageCompletion">The percentage of the
        /// monitoring job. The type of the monitoring job is defined by
        /// MonitoringJobType property.</param>
        /// <param name="monitoringJobType">The type of the monitoring job. The
        /// progress is contained in MonitoringPercentageCompletion
        /// property.</param>
        /// <param name="dataPendingInStagingStorageAccountInMB">The data
        /// pending for replication in MB at staging account.</param>
        /// <param name="dataPendingAtSourceAgentInMB">The data pending at
        /// source virtual machine in MB.</param>
        public A2AProtectedManagedDiskDetails(string diskId = default(string), string recoveryResourceGroupId = default(string), string recoveryTargetDiskId = default(string), string recoveryReplicaDiskId = default(string), string recoveryReplicaDiskAccountType = default(string), string recoveryTargetDiskAccountType = default(string), string diskName = default(string), long? diskCapacityInBytes = default(long?), string primaryStagingAzureStorageAccountId = default(string), string diskType = default(string), bool? resyncRequired = default(bool?), int? monitoringPercentageCompletion = default(int?), string monitoringJobType = default(string), double? dataPendingInStagingStorageAccountInMB = default(double?), double? dataPendingAtSourceAgentInMB = default(double?))
        {
            DiskId = diskId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            RecoveryTargetDiskId = recoveryTargetDiskId;
            RecoveryReplicaDiskId = recoveryReplicaDiskId;
            RecoveryReplicaDiskAccountType = recoveryReplicaDiskAccountType;
            RecoveryTargetDiskAccountType = recoveryTargetDiskAccountType;
            DiskName = diskName;
            DiskCapacityInBytes = diskCapacityInBytes;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            DiskType = diskType;
            ResyncRequired = resyncRequired;
            MonitoringPercentageCompletion = monitoringPercentageCompletion;
            MonitoringJobType = monitoringJobType;
            DataPendingInStagingStorageAccountInMB = dataPendingInStagingStorageAccountInMB;
            DataPendingAtSourceAgentInMB = dataPendingAtSourceAgentInMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the managed disk Arm id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets the recovery disk resource group Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets recovery target disk Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryTargetDiskId")]
        public string RecoveryTargetDiskId { get; set; }

        /// <summary>
        /// Gets or sets recovery replica disk Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryReplicaDiskId")]
        public string RecoveryReplicaDiskId { get; set; }

        /// <summary>
        /// Gets or sets the replica disk type. Its an optional value and will
        /// be same as source disk type if not user provided.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryReplicaDiskAccountType")]
        public string RecoveryReplicaDiskAccountType { get; set; }

        /// <summary>
        /// Gets or sets the target disk type after failover. Its an optional
        /// value and will be same as source disk type if not user provided.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryTargetDiskAccountType")]
        public string RecoveryTargetDiskAccountType { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// Gets or sets the disk capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "diskCapacityInBytes")]
        public long? DiskCapacityInBytes { get; set; }

        /// <summary>
        /// Gets or sets the primary staging storage account.
        /// </summary>
        [JsonProperty(PropertyName = "primaryStagingAzureStorageAccountId")]
        public string PrimaryStagingAzureStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the type of disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether resync is required for this
        /// disk.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public bool? ResyncRequired { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the monitoring job. The type of the
        /// monitoring job is defined by MonitoringJobType property.
        /// </summary>
        [JsonProperty(PropertyName = "monitoringPercentageCompletion")]
        public int? MonitoringPercentageCompletion { get; set; }

        /// <summary>
        /// Gets or sets the type of the monitoring job. The progress is
        /// contained in MonitoringPercentageCompletion property.
        /// </summary>
        [JsonProperty(PropertyName = "monitoringJobType")]
        public string MonitoringJobType { get; set; }

        /// <summary>
        /// Gets or sets the data pending for replication in MB at staging
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "dataPendingInStagingStorageAccountInMB")]
        public double? DataPendingInStagingStorageAccountInMB { get; set; }

        /// <summary>
        /// Gets or sets the data pending at source virtual machine in MB.
        /// </summary>
        [JsonProperty(PropertyName = "dataPendingAtSourceAgentInMB")]
        public double? DataPendingAtSourceAgentInMB { get; set; }

    }
}
