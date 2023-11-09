// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> The EnergyServiceProperties. </summary>
    public partial class EnergyServiceProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EnergyServiceProperties"/>. </summary>
        public EnergyServiceProperties()
        {
            DataPartitionNames = new ChangeTrackingList<DataPartitionName>();
        }

        /// <summary> Initializes a new instance of <see cref="EnergyServiceProperties"/>. </summary>
        /// <param name="dnsName"></param>
        /// <param name="provisioningState"></param>
        /// <param name="authAppId"></param>
        /// <param name="dataPartitionNames"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnergyServiceProperties(string dnsName, ProvisioningState? provisioningState, string authAppId, IList<DataPartitionName> dataPartitionNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DnsName = dnsName;
            ProvisioningState = provisioningState;
            AuthAppId = authAppId;
            DataPartitionNames = dataPartitionNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the dns name. </summary>
        public string DnsName { get; }
        /// <summary> Gets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the auth app id. </summary>
        public string AuthAppId { get; set; }
        /// <summary> Gets the data partition names. </summary>
        public IList<DataPartitionName> DataPartitionNames { get; }
    }
}
