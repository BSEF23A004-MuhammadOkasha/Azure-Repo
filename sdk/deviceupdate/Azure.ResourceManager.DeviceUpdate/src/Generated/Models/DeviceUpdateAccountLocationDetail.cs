// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The DeviceUpdateAccountLocationDetail. </summary>
    public partial class DeviceUpdateAccountLocationDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceUpdateAccountLocationDetail"/>. </summary>
        internal DeviceUpdateAccountLocationDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceUpdateAccountLocationDetail"/>. </summary>
        /// <param name="name"></param>
        /// <param name="role"> Whether the location is primary or failover. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceUpdateAccountLocationDetail(string name, DeviceUpdateAccountLocationRole? role, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Role = role;
            _rawData = rawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Whether the location is primary or failover. </summary>
        public DeviceUpdateAccountLocationRole? Role { get; }
    }
}
