// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineKeySetPatchParameters represents the body of the request to patch the bare metal machine key set. </summary>
    public partial class NetworkCloudBareMetalMachineKeySetPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachineKeySetPatch"/>. </summary>
        public NetworkCloudBareMetalMachineKeySetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            JumpHostsAllowed = new ChangeTrackingList<IPAddress>();
            UserList = new ChangeTrackingList<KeySetUser>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachineKeySetPatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="expireOn"> The date and time after which the users in this key set will be removed from the bare metal machines. </param>
        /// <param name="jumpHostsAllowed"> The list of IP addresses of jump hosts with management network access from which a login will be allowed for the users. </param>
        /// <param name="userList"> The unique list of permitted users. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudBareMetalMachineKeySetPatch(IDictionary<string, string> tags, DateTimeOffset? expireOn, IList<IPAddress> jumpHostsAllowed, IList<KeySetUser> userList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            ExpireOn = expireOn;
            JumpHostsAllowed = jumpHostsAllowed;
            UserList = userList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The date and time after which the users in this key set will be removed from the bare metal machines. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The list of IP addresses of jump hosts with management network access from which a login will be allowed for the users. </summary>
        public IList<IPAddress> JumpHostsAllowed { get; }
        /// <summary> The unique list of permitted users. </summary>
        public IList<KeySetUser> UserList { get; }
    }
}
