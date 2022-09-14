// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary> A class representing the ComponentLinkedStorageAccount data model. </summary>
    public partial class ComponentLinkedStorageAccountData : ResourceData
    {
        /// <summary> Initializes a new instance of ComponentLinkedStorageAccountData. </summary>
        public ComponentLinkedStorageAccountData()
        {
        }

        /// <summary> Initializes a new instance of ComponentLinkedStorageAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="linkedStorageAccount"> Linked storage account resource ID. </param>
        internal ComponentLinkedStorageAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string linkedStorageAccount) : base(id, name, resourceType, systemData)
        {
            LinkedStorageAccount = linkedStorageAccount;
        }

        /// <summary> Linked storage account resource ID. </summary>
        public string LinkedStorageAccount { get; set; }
    }
}
