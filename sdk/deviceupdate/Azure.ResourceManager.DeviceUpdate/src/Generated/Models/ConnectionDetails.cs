// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private endpoint connection proxy object properties. </summary>
    public partial class ConnectionDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionDetails"/>. </summary>
        public ConnectionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionDetails"/>. </summary>
        /// <param name="id"> Connection details ID. </param>
        /// <param name="privateIPAddress"> Private IP address. </param>
        /// <param name="linkIdentifier"> Link ID. </param>
        /// <param name="groupId"> Group ID. </param>
        /// <param name="memberName"> Member name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionDetails(string id, string privateIPAddress, string linkIdentifier, string groupId, string memberName, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            PrivateIPAddress = privateIPAddress;
            LinkIdentifier = linkIdentifier;
            GroupId = groupId;
            MemberName = memberName;
            _rawData = rawData;
        }

        /// <summary> Connection details ID. </summary>
        public string Id { get; }
        /// <summary> Private IP address. </summary>
        public string PrivateIPAddress { get; }
        /// <summary> Link ID. </summary>
        public string LinkIdentifier { get; }
        /// <summary> Group ID. </summary>
        public string GroupId { get; }
        /// <summary> Member name. </summary>
        public string MemberName { get; }
    }
}
