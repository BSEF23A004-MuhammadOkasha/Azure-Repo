// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLake.Analytics.Models
{
    /// <summary> The parameters used to add a new Azure Storage account. </summary>
    public partial class StorageAccountInformationCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of StorageAccountInformationCreateOrUpdateContent. </summary>
        /// <param name="accessKey"> The access key associated with this Azure Storage account that will be used to connect to it. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessKey"/> is null. </exception>
        public StorageAccountInformationCreateOrUpdateContent(string accessKey)
        {
            if (accessKey == null)
            {
                throw new ArgumentNullException(nameof(accessKey));
            }

            AccessKey = accessKey;
        }

        /// <summary> The access key associated with this Azure Storage account that will be used to connect to it. </summary>
        public string AccessKey { get; }
        /// <summary> The optional suffix for the storage account. </summary>
        public string Suffix { get; set; }
    }
}
