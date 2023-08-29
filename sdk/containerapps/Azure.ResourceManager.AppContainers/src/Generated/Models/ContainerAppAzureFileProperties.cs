// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Azure File Properties. </summary>
    public partial class ContainerAppAzureFileProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureFileProperties"/>. </summary>
        public ContainerAppAzureFileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureFileProperties"/>. </summary>
        /// <param name="accountName"> Storage account name for azure file. </param>
        /// <param name="accountKey"> Storage account key for azure file. </param>
        /// <param name="accessMode"> Access mode for storage. </param>
        /// <param name="shareName"> Azure file share name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppAzureFileProperties(string accountName, string accountKey, ContainerAppAccessMode? accessMode, string shareName, Dictionary<string, BinaryData> rawData)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            AccessMode = accessMode;
            ShareName = shareName;
            _rawData = rawData;
        }

        /// <summary> Storage account name for azure file. </summary>
        public string AccountName { get; set; }
        /// <summary> Storage account key for azure file. </summary>
        public string AccountKey { get; set; }
        /// <summary> Access mode for storage. </summary>
        public ContainerAppAccessMode? AccessMode { get; set; }
        /// <summary> Azure file share name. </summary>
        public string ShareName { get; set; }
    }
}
