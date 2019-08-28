// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure VM workload-specific protected item representing SAP HANA
    /// Database.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureVmWorkloadSAPHanaDatabase")]
    public partial class AzureVmWorkloadSAPHanaDatabaseProtectedItem : AzureVmWorkloadProtectedItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureVmWorkloadSAPHanaDatabaseProtectedItem class.
        /// </summary>
        public AzureVmWorkloadSAPHanaDatabaseProtectedItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureVmWorkloadSAPHanaDatabaseProtectedItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup management for
        /// the backed up item. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="workloadType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource', 'SQLDataBase',
        /// 'AzureFileShare', 'SAPHanaDatabase', 'SAPAseDatabase'</param>
        /// <param name="containerName">Unique name of container</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="policyId">ID of the backup policy with which this item
        /// is backed up.</param>
        /// <param name="lastRecoveryPoint">Timestamp when the last (latest)
        /// backup copy was created for this backup item.</param>
        /// <param name="backupSetName">Name of the backup set the backup item
        /// belongs to</param>
        /// <param name="createMode">Create mode to indicate recovery of
        /// existing soft deleted data source or creation of new data source.
        /// Possible values include: 'Invalid', 'Default', 'Recover'</param>
        /// <param name="deferredDeleteTimeInUTC">Time for deferred deletion in
        /// UTC</param>
        /// <param name="isScheduledForDeferredDelete">Flag to identify whether
        /// the DS is scheduled for deferred delete</param>
        /// <param name="deferredDeleteTimeRemaining">Time remaining before the
        /// DS marked for deferred delete is permanently deleted</param>
        /// <param name="isDeferredDeleteScheduleUpcoming">Flag to identify
        /// whether the deferred deleted DS is to be purged soon</param>
        /// <param name="isRehydrate">Flag to identify that deferred deleted DS
        /// is to be moved into Pause state</param>
        /// <param name="friendlyName">Friendly name of the DB represented by
        /// this backup item.</param>
        /// <param name="serverName">Host/Cluster Name for instance or
        /// AG</param>
        /// <param name="parentName">Parent name of the DB such as Instance or
        /// Availability Group.</param>
        /// <param name="parentType">Parent type of protected item, example:
        /// for a DB, standalone server or distributed</param>
        /// <param name="protectionStatus">Backup status of this backup
        /// item.</param>
        /// <param name="protectionState">Backup state of this backup item.
        /// Possible values include: 'Invalid', 'IRPending', 'Protected',
        /// 'ProtectionError', 'ProtectionStopped', 'ProtectionPaused'</param>
        /// <param name="lastBackupStatus">Last backup operation status.
        /// Possible values: Healthy, Unhealthy. Possible values include:
        /// 'Invalid', 'Healthy', 'Unhealthy', 'IRPending'</param>
        /// <param name="lastBackupTime">Timestamp of the last backup operation
        /// on this backup item.</param>
        /// <param name="lastBackupErrorDetail">Error details in last
        /// backup</param>
        /// <param name="protectedItemDataSourceId">Data ID of the protected
        /// item.</param>
        /// <param name="protectedItemHealthStatus">Health status of the backup
        /// item, evaluated based on last heartbeat received. Possible values
        /// include: 'Invalid', 'Healthy', 'Unhealthy', 'NotReachable',
        /// 'IRPending'</param>
        /// <param name="extendedInfo">Additional information for this backup
        /// item.</param>
        public AzureVmWorkloadSAPHanaDatabaseProtectedItem(string backupManagementType = default(string), string workloadType = default(string), string containerName = default(string), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?), string backupSetName = default(string), string createMode = default(string), System.DateTime? deferredDeleteTimeInUTC = default(System.DateTime?), bool? isScheduledForDeferredDelete = default(bool?), string deferredDeleteTimeRemaining = default(string), bool? isDeferredDeleteScheduleUpcoming = default(bool?), bool? isRehydrate = default(bool?), string friendlyName = default(string), string serverName = default(string), string parentName = default(string), string parentType = default(string), string protectionStatus = default(string), string protectionState = default(string), string lastBackupStatus = default(string), System.DateTime? lastBackupTime = default(System.DateTime?), ErrorDetail lastBackupErrorDetail = default(ErrorDetail), string protectedItemDataSourceId = default(string), string protectedItemHealthStatus = default(string), AzureVmWorkloadProtectedItemExtendedInfo extendedInfo = default(AzureVmWorkloadProtectedItemExtendedInfo))
            : base(backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode, deferredDeleteTimeInUTC, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate, friendlyName, serverName, parentName, parentType, protectionStatus, protectionState, lastBackupStatus, lastBackupTime, lastBackupErrorDetail, protectedItemDataSourceId, protectedItemHealthStatus, extendedInfo)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
