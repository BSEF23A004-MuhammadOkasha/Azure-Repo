// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The UserIdentityProperties. </summary>
    public partial class UserIdentityProperties
    {
        /// <summary> Initializes a new instance of UserIdentityProperties. </summary>
        public UserIdentityProperties()
        {
        }

        /// <summary> Initializes a new instance of UserIdentityProperties. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        internal UserIdentityProperties(Guid? principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public Guid? PrincipalId { get; set; }
        /// <summary> The client id of user assigned identity. </summary>
        public string ClientId { get; set; }
    }
}
