// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The ResourceIdentity. </summary>
    public partial class ResourceIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceIdentity"/>. </summary>
        /// <param name="useSystemAssignedIdentity"> Indicates whether to use System Assigned Managed Identity. Mutual exclusive with User Assigned Managed Identity. </param>
        public ResourceIdentity(bool useSystemAssignedIdentity)
        {
            UseSystemAssignedIdentity = useSystemAssignedIdentity;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceIdentity"/>. </summary>
        /// <param name="userAssignedIdentity"> The user assigned managed identity's ARM ID to use when accessing a resource. </param>
        /// <param name="useSystemAssignedIdentity"> Indicates whether to use System Assigned Managed Identity. Mutual exclusive with User Assigned Managed Identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceIdentity(string userAssignedIdentity, bool useSystemAssignedIdentity, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserAssignedIdentity = userAssignedIdentity;
            UseSystemAssignedIdentity = useSystemAssignedIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceIdentity"/> for deserialization. </summary>
        internal ResourceIdentity()
        {
        }

        /// <summary> The user assigned managed identity's ARM ID to use when accessing a resource. </summary>
        public string UserAssignedIdentity { get; set; }
        /// <summary> Indicates whether to use System Assigned Managed Identity. Mutual exclusive with User Assigned Managed Identity. </summary>
        public bool UseSystemAssignedIdentity { get; set; }
    }
}
