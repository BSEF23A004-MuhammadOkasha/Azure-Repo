// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyVaultManagementClient.Models
{
    /// <summary> Properties of the vault access policy. </summary>
    public partial class VaultAccessPolicyProperties
    {
        /// <summary> Initializes a new instance of VaultAccessPolicyProperties. </summary>
        /// <param name="accessPolicies"> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault&apos;s tenant ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicies"/> is null. </exception>
        public VaultAccessPolicyProperties(IEnumerable<AccessPolicyEntry> accessPolicies)
        {
            if (accessPolicies == null)
            {
                throw new ArgumentNullException(nameof(accessPolicies));
            }

            AccessPolicies = accessPolicies.ToList();
        }

        /// <summary> Initializes a new instance of VaultAccessPolicyProperties. </summary>
        /// <param name="accessPolicies"> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault&apos;s tenant ID. </param>
        internal VaultAccessPolicyProperties(IList<AccessPolicyEntry> accessPolicies)
        {
            AccessPolicies = accessPolicies;
        }

        /// <summary> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault&apos;s tenant ID. </summary>
        public IList<AccessPolicyEntry> AccessPolicies { get; }
    }
}
