// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxStorageAccount. </summary>
    public partial class NginxStorageAccount
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NginxStorageAccount"/>. </summary>
        public NginxStorageAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxStorageAccount"/>. </summary>
        /// <param name="accountName"></param>
        /// <param name="containerName"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxStorageAccount(string accountName, string containerName, Dictionary<string, BinaryData> rawData)
        {
            AccountName = accountName;
            ContainerName = containerName;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Gets or sets the container name. </summary>
        public string ContainerName { get; set; }
    }
}
