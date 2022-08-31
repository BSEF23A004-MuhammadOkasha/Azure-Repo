// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The managed resources in customer subscription. </summary>
    public partial class ManagedResources
    {
        /// <summary> Initializes a new instance of ManagedResources. </summary>
        internal ManagedResources()
        {
        }

        /// <summary> Initializes a new instance of ManagedResources. </summary>
        /// <param name="eventHubNamespace"> Gets the managed event hub namespace resource identifier. </param>
        /// <param name="resourceGroup"> Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account. </param>
        /// <param name="storageAccount"> Gets the managed storage account resource identifier. </param>
        internal ManagedResources(string eventHubNamespace, string resourceGroup, string storageAccount)
        {
            EventHubNamespace = eventHubNamespace;
            ResourceGroup = resourceGroup;
            StorageAccount = storageAccount;
        }

        /// <summary> Gets the managed event hub namespace resource identifier. </summary>
        public string EventHubNamespace { get; }
        /// <summary> Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account. </summary>
        public string ResourceGroup { get; }
        /// <summary> Gets the managed storage account resource identifier. </summary>
        public string StorageAccount { get; }
    }
}
