// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the datacenter address. </summary>
    public partial class DataCenterAddressContent
    {
        /// <summary> Initializes a new instance of DataCenterAddressContent. </summary>
        /// <param name="storageLocation"> Storage location. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="skuName"> Sku Name for which the data center address requested. </param>
        public DataCenterAddressContent(AzureLocation storageLocation, DataBoxSkuName skuName)
        {
            StorageLocation = storageLocation;
            SkuName = skuName;
        }

        /// <summary> Storage location. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </summary>
        public AzureLocation StorageLocation { get; }
        /// <summary> Sku Name for which the data center address requested. </summary>
        public DataBoxSkuName SkuName { get; }
    }
}
