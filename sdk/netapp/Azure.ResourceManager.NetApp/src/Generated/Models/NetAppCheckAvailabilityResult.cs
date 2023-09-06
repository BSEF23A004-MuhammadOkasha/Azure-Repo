// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Information regarding availability of a resource. </summary>
    public partial class NetAppCheckAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppCheckAvailabilityResult"/>. </summary>
        internal NetAppCheckAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppCheckAvailabilityResult"/>. </summary>
        /// <param name="isAvailable"> &lt;code&gt;true&lt;/code&gt; indicates name is valid and available. &lt;code&gt;false&lt;/code&gt; indicates the name is invalid, unavailable, or both. </param>
        /// <param name="reason"> &lt;code&gt;Invalid&lt;/code&gt; indicates the name provided does not match Azure App Service naming requirements. &lt;code&gt;AlreadyExists&lt;/code&gt; indicates that the name is already in use and is therefore unavailable. </param>
        /// <param name="message"> If reason == invalid, provide the user with the reason why the given name is invalid, and provide the resource naming requirements so that the user can select a valid name. If reason == AlreadyExists, explain that resource name is already in use, and direct them to select a different name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppCheckAvailabilityResult(bool? isAvailable, NetAppNameUnavailableReason? reason, string message, Dictionary<string, BinaryData> rawData)
        {
            IsAvailable = isAvailable;
            Reason = reason;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; indicates name is valid and available. &lt;code&gt;false&lt;/code&gt; indicates the name is invalid, unavailable, or both. </summary>
        public bool? IsAvailable { get; }
        /// <summary> &lt;code&gt;Invalid&lt;/code&gt; indicates the name provided does not match Azure App Service naming requirements. &lt;code&gt;AlreadyExists&lt;/code&gt; indicates that the name is already in use and is therefore unavailable. </summary>
        public NetAppNameUnavailableReason? Reason { get; }
        /// <summary> If reason == invalid, provide the user with the reason why the given name is invalid, and provide the resource naming requirements so that the user can select a valid name. If reason == AlreadyExists, explain that resource name is already in use, and direct them to select a different name. </summary>
        public string Message { get; }
    }
}
