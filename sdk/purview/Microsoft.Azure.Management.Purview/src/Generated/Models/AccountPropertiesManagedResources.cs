// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Purview.Models
{
    using System.Linq;

    /// <summary>
    /// Gets the resource identifiers of the managed resources.
    /// </summary>
    public partial class AccountPropertiesManagedResources : ManagedResources
    {
        /// <summary>
        /// Initializes a new instance of the AccountPropertiesManagedResources
        /// class.
        /// </summary>
        public AccountPropertiesManagedResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountPropertiesManagedResources
        /// class.
        /// </summary>
        /// <param name="eventHubNamespace">Gets the managed event hub
        /// namespace resource identifier.</param>
        /// <param name="resourceGroup">Gets the managed resource group
        /// resource identifier. This resource group will host resource
        /// dependencies for the account.</param>
        /// <param name="storageAccount">Gets the managed storage account
        /// resource identifier.</param>
        public AccountPropertiesManagedResources(string eventHubNamespace = default(string), string resourceGroup = default(string), string storageAccount = default(string))
            : base(eventHubNamespace, resourceGroup, storageAccount)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
