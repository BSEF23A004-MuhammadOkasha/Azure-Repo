// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Settings properties for Active Directory (AD). </summary>
    public partial class StorageActiveDirectoryProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageActiveDirectoryProperties"/>. </summary>
        /// <param name="domainName"> Specifies the primary domain that the AD DNS server is authoritative for. </param>
        /// <param name="domainGuid"> Specifies the domain GUID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public StorageActiveDirectoryProperties(string domainName, Guid domainGuid)
        {
            Argument.AssertNotNull(domainName, nameof(domainName));

            DomainName = domainName;
            DomainGuid = domainGuid;
        }

        /// <summary> Initializes a new instance of <see cref="StorageActiveDirectoryProperties"/>. </summary>
        /// <param name="domainName"> Specifies the primary domain that the AD DNS server is authoritative for. </param>
        /// <param name="netBiosDomainName"> Specifies the NetBIOS domain name. </param>
        /// <param name="forestName"> Specifies the Active Directory forest to get. </param>
        /// <param name="domainGuid"> Specifies the domain GUID. </param>
        /// <param name="domainSid"> Specifies the security identifier (SID). </param>
        /// <param name="azureStorageSid"> Specifies the security identifier (SID) for Azure Storage. </param>
        /// <param name="samAccountName"> Specifies the Active Directory SAMAccountName for Azure Storage. </param>
        /// <param name="accountType"> Specifies the Active Directory account type for Azure Storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageActiveDirectoryProperties(string domainName, string netBiosDomainName, string forestName, Guid domainGuid, string domainSid, string azureStorageSid, string samAccountName, ActiveDirectoryAccountType? accountType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainName = domainName;
            NetBiosDomainName = netBiosDomainName;
            ForestName = forestName;
            DomainGuid = domainGuid;
            DomainSid = domainSid;
            AzureStorageSid = azureStorageSid;
            SamAccountName = samAccountName;
            AccountType = accountType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageActiveDirectoryProperties"/> for deserialization. </summary>
        internal StorageActiveDirectoryProperties()
        {
        }

        /// <summary> Specifies the primary domain that the AD DNS server is authoritative for. </summary>
        public string DomainName { get; set; }
        /// <summary> Specifies the NetBIOS domain name. </summary>
        public string NetBiosDomainName { get; set; }
        /// <summary> Specifies the Active Directory forest to get. </summary>
        public string ForestName { get; set; }
        /// <summary> Specifies the domain GUID. </summary>
        public Guid DomainGuid { get; set; }
        /// <summary> Specifies the security identifier (SID). </summary>
        public string DomainSid { get; set; }
        /// <summary> Specifies the security identifier (SID) for Azure Storage. </summary>
        public string AzureStorageSid { get; set; }
        /// <summary> Specifies the Active Directory SAMAccountName for Azure Storage. </summary>
        public string SamAccountName { get; set; }
        /// <summary> Specifies the Active Directory account type for Azure Storage. </summary>
        public ActiveDirectoryAccountType? AccountType { get; set; }
    }
}
