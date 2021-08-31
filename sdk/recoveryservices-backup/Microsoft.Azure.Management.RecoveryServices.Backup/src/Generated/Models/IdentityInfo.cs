// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Encapsulates Managed Identity related information
    /// </summary>
    public partial class IdentityInfo
    {
        /// <summary>
        /// Initializes a new instance of the IdentityInfo class.
        /// </summary>
        public IdentityInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityInfo class.
        /// </summary>
        /// <param name="isSystemAssignedIdentity">To differentiate if the
        /// managed identity is system assigned or user assigned</param>
        /// <param name="managedIdentityResourceId">Managed Identity Resource
        /// Id
        /// Optional: Might not be required in the case of system assigned
        /// managed identity</param>
        public IdentityInfo(bool? isSystemAssignedIdentity = default(bool?), string managedIdentityResourceId = default(string))
        {
            IsSystemAssignedIdentity = isSystemAssignedIdentity;
            ManagedIdentityResourceId = managedIdentityResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets to differentiate if the managed identity is system
        /// assigned or user assigned
        /// </summary>
        [JsonProperty(PropertyName = "isSystemAssignedIdentity")]
        public bool? IsSystemAssignedIdentity { get; set; }

        /// <summary>
        /// Gets or sets managed Identity Resource Id
        /// Optional: Might not be required in the case of system assigned
        /// managed identity
        /// </summary>
        [JsonProperty(PropertyName = "managedIdentityResourceId")]
        public string ManagedIdentityResourceId { get; set; }

    }
}
