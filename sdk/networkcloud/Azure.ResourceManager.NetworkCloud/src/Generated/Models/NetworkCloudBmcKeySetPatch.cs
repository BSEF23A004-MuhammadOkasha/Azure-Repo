// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BmcKeySetPatchParameters represents the body of the request to patch the baseboard management controller key set. </summary>
    public partial class NetworkCloudBmcKeySetPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBmcKeySetPatch"/>. </summary>
        public NetworkCloudBmcKeySetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            UserList = new ChangeTrackingList<KeySetUser>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBmcKeySetPatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="expireOn"> The date and time after which the users in this key set will be removed from the baseboard management controllers. </param>
        /// <param name="userList"> The unique list of permitted users. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudBmcKeySetPatch(IDictionary<string, string> tags, DateTimeOffset? expireOn, IList<KeySetUser> userList, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            ExpireOn = expireOn;
            UserList = userList;
            _rawData = rawData;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The date and time after which the users in this key set will be removed from the baseboard management controllers. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The unique list of permitted users. </summary>
        public IList<KeySetUser> UserList { get; }
    }
}
