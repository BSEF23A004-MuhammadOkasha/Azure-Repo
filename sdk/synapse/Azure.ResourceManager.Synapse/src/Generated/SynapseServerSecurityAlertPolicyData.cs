// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseServerSecurityAlertPolicy data model.
    /// Workspace managed Sql server security alert policy.
    /// </summary>
    public partial class SynapseServerSecurityAlertPolicyData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseServerSecurityAlertPolicyData"/>. </summary>
        public SynapseServerSecurityAlertPolicyData()
        {
            DisabledAlerts = new ChangeTrackingList<string>();
            EmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseServerSecurityAlertPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific server. </param>
        /// <param name="disabledAlerts"> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action. </param>
        /// <param name="emailAddresses"> Specifies an array of e-mail addresses to which the alert is sent. </param>
        /// <param name="enableEmailToAccountAdmins"> Specifies that the alert is sent to the account administrators. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the Threat Detection audit storage account. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the Threat Detection audit logs. </param>
        /// <param name="createdOn"> Specifies the UTC creation time of the policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseServerSecurityAlertPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SynapseSecurityAlertPolicyState? state, IList<string> disabledAlerts, IList<string> emailAddresses, bool? enableEmailToAccountAdmins, string storageEndpoint, string storageAccountAccessKey, int? retentionDays, DateTimeOffset? createdOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            DisabledAlerts = disabledAlerts;
            EmailAddresses = emailAddresses;
            EnableEmailToAccountAdmins = enableEmailToAccountAdmins;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific server. </summary>
        public SynapseSecurityAlertPolicyState? State { get; set; }
        /// <summary> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action. </summary>
        public IList<string> DisabledAlerts { get; }
        /// <summary> Specifies an array of e-mail addresses to which the alert is sent. </summary>
        public IList<string> EmailAddresses { get; }
        /// <summary> Specifies that the alert is sent to the account administrators. </summary>
        public bool? EnableEmailToAccountAdmins { get; set; }
        /// <summary> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </summary>
        public string StorageEndpoint { get; set; }
        /// <summary> Specifies the identifier key of the Threat Detection audit storage account. </summary>
        public string StorageAccountAccessKey { get; set; }
        /// <summary> Specifies the number of days to keep in the Threat Detection audit logs. </summary>
        public int? RetentionDays { get; set; }
        /// <summary> Specifies the UTC creation time of the policy. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
