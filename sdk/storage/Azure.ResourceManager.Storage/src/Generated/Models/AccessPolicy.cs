// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The AccessPolicy. </summary>
    public partial class AccessPolicy
    {
        /// <summary> Initializes a new instance of AccessPolicy. </summary>
        public AccessPolicy()
        {
        }

        /// <summary> Initializes a new instance of AccessPolicy. </summary>
        /// <param name="startTime"> Start time of the access policy. </param>
        /// <param name="expiryTime"> Expiry time of the access policy. </param>
        /// <param name="permission"> List of abbreviated permissions. </param>
        internal AccessPolicy(DateTimeOffset? startTime, DateTimeOffset? expiryTime, string permission)
        {
            StartTime = startTime;
            ExpiryTime = expiryTime;
            Permission = permission;
        }

        /// <summary> Start time of the access policy. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> Expiry time of the access policy. </summary>
        public DateTimeOffset? ExpiryTime { get; set; }
        /// <summary> List of abbreviated permissions. </summary>
        public string Permission { get; set; }
    }
}
