// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Azure backup discrete RecoveryPoint. </summary>
    public partial class DataProtectionBackupDiscreteRecoveryPointProperties : DataProtectionBackupRecoveryPointProperties
    {
        /// <summary> Initializes a new instance of DataProtectionBackupDiscreteRecoveryPointProperties. </summary>
        /// <param name="recoverOn"></param>
        public DataProtectionBackupDiscreteRecoveryPointProperties(DateTimeOffset recoverOn)
        {
            RecoveryPointDataStoresDetails = new ChangeTrackingList<RecoveryPointDataStoreDetail>();
            RecoverOn = recoverOn;
            ObjectType = "AzureBackupDiscreteRecoveryPoint";
        }

        /// <summary> Initializes a new instance of DataProtectionBackupDiscreteRecoveryPointProperties. </summary>
        /// <param name="objectType"></param>
        /// <param name="friendlyName"></param>
        /// <param name="recoveryPointDataStoresDetails"></param>
        /// <param name="recoverOn"></param>
        /// <param name="policyName"></param>
        /// <param name="policyVersion"></param>
        /// <param name="recoveryPointId"></param>
        /// <param name="recoveryPointType"></param>
        /// <param name="retentionTagName"></param>
        /// <param name="retentionTagVersion"></param>
        /// <param name="expireOn"></param>
        internal DataProtectionBackupDiscreteRecoveryPointProperties(string objectType, string friendlyName, IList<RecoveryPointDataStoreDetail> recoveryPointDataStoresDetails, DateTimeOffset recoverOn, string policyName, string policyVersion, string recoveryPointId, string recoveryPointType, string retentionTagName, string retentionTagVersion, DateTimeOffset? expireOn) : base(objectType)
        {
            FriendlyName = friendlyName;
            RecoveryPointDataStoresDetails = recoveryPointDataStoresDetails;
            RecoverOn = recoverOn;
            PolicyName = policyName;
            PolicyVersion = policyVersion;
            RecoveryPointId = recoveryPointId;
            RecoveryPointType = recoveryPointType;
            RetentionTagName = retentionTagName;
            RetentionTagVersion = retentionTagVersion;
            ExpireOn = expireOn;
            ObjectType = objectType ?? "AzureBackupDiscreteRecoveryPoint";
        }

        /// <summary> Gets or sets the friendly name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Gets the recovery point data stores details. </summary>
        public IList<RecoveryPointDataStoreDetail> RecoveryPointDataStoresDetails { get; }
        /// <summary> Gets or sets the recover on. </summary>
        public DateTimeOffset RecoverOn { get; set; }
        /// <summary> Gets or sets the policy name. </summary>
        public string PolicyName { get; set; }
        /// <summary> Gets or sets the policy version. </summary>
        public string PolicyVersion { get; set; }
        /// <summary> Gets or sets the recovery point id. </summary>
        public string RecoveryPointId { get; set; }
        /// <summary> Gets or sets the recovery point type. </summary>
        public string RecoveryPointType { get; set; }
        /// <summary> Gets or sets the retention tag name. </summary>
        public string RetentionTagName { get; set; }
        /// <summary> Gets or sets the retention tag version. </summary>
        public string RetentionTagVersion { get; set; }
        /// <summary> Gets the expire on. </summary>
        public DateTimeOffset? ExpireOn { get; }
    }
}
