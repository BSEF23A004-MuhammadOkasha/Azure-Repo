// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing the MySqlServerSecurityAlertPolicy data model.
    /// A server security alert policy.
    /// </summary>
    public partial class MySqlServerSecurityAlertPolicyData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlServerSecurityAlertPolicyData"/>. </summary>
        public MySqlServerSecurityAlertPolicyData()
        {
            DisabledAlerts = new ChangeTrackingList<string>();
            EmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerSecurityAlertPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the policy, whether it is enabled or disabled. </param>
        /// <param name="disabledAlerts"> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly. </param>
        /// <param name="emailAddresses"> Specifies an array of e-mail addresses to which the alert is sent. </param>
        /// <param name="sendToEmailAccountAdmins"> Specifies that the alert is sent to the account administrators. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the Threat Detection audit storage account. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the Threat Detection audit logs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlServerSecurityAlertPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MySqlServerSecurityAlertPolicyState? state, IList<string> disabledAlerts, IList<string> emailAddresses, bool? sendToEmailAccountAdmins, string storageEndpoint, string storageAccountAccessKey, int? retentionDays, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            DisabledAlerts = disabledAlerts;
            EmailAddresses = emailAddresses;
            SendToEmailAccountAdmins = sendToEmailAccountAdmins;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the state of the policy, whether it is enabled or disabled. </summary>
        public MySqlServerSecurityAlertPolicyState? State { get; set; }
        /// <summary> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly. </summary>
        public IList<string> DisabledAlerts { get; }
        /// <summary> Specifies an array of e-mail addresses to which the alert is sent. </summary>
        public IList<string> EmailAddresses { get; }
        /// <summary> Specifies that the alert is sent to the account administrators. </summary>
        public bool? SendToEmailAccountAdmins { get; set; }
        /// <summary> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </summary>
        public string StorageEndpoint { get; set; }
        /// <summary> Specifies the identifier key of the Threat Detection audit storage account. </summary>
        public string StorageAccountAccessKey { get; set; }
        /// <summary> Specifies the number of days to keep in the Threat Detection audit logs. </summary>
        public int? RetentionDays { get; set; }
    }
}
