// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents a RegistrationInfo definition. </summary>
    public partial class HostPoolRegistrationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HostPoolRegistrationInfo"/>. </summary>
        public HostPoolRegistrationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HostPoolRegistrationInfo"/>. </summary>
        /// <param name="expireOn"> Expiration time of registration token. </param>
        /// <param name="token"> The registration token base64 encoded string. </param>
        /// <param name="registrationTokenOperation"> The type of resetting the token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HostPoolRegistrationInfo(DateTimeOffset? expireOn, string token, HostPoolRegistrationTokenOperation? registrationTokenOperation, Dictionary<string, BinaryData> rawData)
        {
            ExpireOn = expireOn;
            Token = token;
            RegistrationTokenOperation = registrationTokenOperation;
            _rawData = rawData;
        }

        /// <summary> Expiration time of registration token. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The registration token base64 encoded string. </summary>
        public string Token { get; set; }
        /// <summary> The type of resetting the token. </summary>
        public HostPoolRegistrationTokenOperation? RegistrationTokenOperation { get; set; }
    }
}
