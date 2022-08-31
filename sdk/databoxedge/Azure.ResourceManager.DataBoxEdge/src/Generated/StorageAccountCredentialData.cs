// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class representing the StorageAccountCredential data model. </summary>
    public partial class StorageAccountCredentialData : ResourceData
    {
        /// <summary> Initializes a new instance of StorageAccountCredentialData. </summary>
        /// <param name="alias"> Alias for the storage account. </param>
        /// <param name="sslStatus"> Signifies whether SSL needs to be enabled or not. </param>
        /// <param name="accountType"> Type of storage accessed on the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public StorageAccountCredentialData(string @alias, SSLStatus sslStatus, AccountType accountType)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            Alias = @alias;
            SslStatus = sslStatus;
            AccountType = accountType;
        }

        /// <summary> Initializes a new instance of StorageAccountCredentialData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="alias"> Alias for the storage account. </param>
        /// <param name="userName"> Username for the storage account. </param>
        /// <param name="accountKey"> Encrypted storage key. </param>
        /// <param name="connectionString"> Connection string for the storage account. Use this string if username and account key are not specified. </param>
        /// <param name="sslStatus"> Signifies whether SSL needs to be enabled or not. </param>
        /// <param name="blobDomainName"> Blob end point for private clouds. </param>
        /// <param name="accountType"> Type of storage accessed on the storage account. </param>
        /// <param name="storageAccountId"> Id of the storage account. </param>
        internal StorageAccountCredentialData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string @alias, string userName, AsymmetricEncryptedSecret accountKey, string connectionString, SSLStatus sslStatus, string blobDomainName, AccountType accountType, string storageAccountId) : base(id, name, resourceType, systemData)
        {
            Alias = @alias;
            UserName = userName;
            AccountKey = accountKey;
            ConnectionString = connectionString;
            SslStatus = sslStatus;
            BlobDomainName = blobDomainName;
            AccountType = accountType;
            StorageAccountId = storageAccountId;
        }

        /// <summary> Alias for the storage account. </summary>
        public string Alias { get; set; }
        /// <summary> Username for the storage account. </summary>
        public string UserName { get; set; }
        /// <summary> Encrypted storage key. </summary>
        public AsymmetricEncryptedSecret AccountKey { get; set; }
        /// <summary> Connection string for the storage account. Use this string if username and account key are not specified. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Signifies whether SSL needs to be enabled or not. </summary>
        public SSLStatus SslStatus { get; set; }
        /// <summary> Blob end point for private clouds. </summary>
        public string BlobDomainName { get; set; }
        /// <summary> Type of storage accessed on the storage account. </summary>
        public AccountType AccountType { get; set; }
        /// <summary> Id of the storage account. </summary>
        public string StorageAccountId { get; set; }
    }
}
