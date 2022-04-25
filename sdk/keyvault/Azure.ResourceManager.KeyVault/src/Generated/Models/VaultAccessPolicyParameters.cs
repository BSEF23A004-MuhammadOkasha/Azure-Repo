// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Parameters for updating the access policy in a vault. </summary>
    public partial class VaultAccessPolicyParameters : ResourceData
    {
        /// <summary> Initializes a new instance of VaultAccessPolicyParameters. </summary>
        /// <param name="properties"> Properties of the access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public VaultAccessPolicyParameters(VaultAccessPolicyProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of VaultAccessPolicyParameters. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The resource type of the access policy. </param>
        /// <param name="properties"> Properties of the access policy. </param>
        internal VaultAccessPolicyParameters(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, VaultAccessPolicyProperties properties) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Properties = properties;
        }

        /// <summary> The resource type of the access policy. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Properties of the access policy. </summary>
        internal VaultAccessPolicyProperties Properties { get; set; }
        /// <summary> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault&apos;s tenant ID. </summary>
        public IList<AccessPolicyEntry> AccessPolicies
        {
            get => Properties is null ? default : Properties.AccessPolicies;
            set => Properties = new VaultAccessPolicyProperties(value);
        }
    }
}
