// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> AuthenticationPolicy of type Open. </summary>
    internal partial class OpenAuthenticationAccessPolicies
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OpenAuthenticationAccessPolicies"/>. </summary>
        public OpenAuthenticationAccessPolicies()
        {
            AccessPolicies = new ChangeTrackingDictionary<string, OpenAuthenticationAccessPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="OpenAuthenticationAccessPolicies"/>. </summary>
        /// <param name="accessPolicies"> Open authentication policies. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenAuthenticationAccessPolicies(IDictionary<string, OpenAuthenticationAccessPolicy> accessPolicies, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccessPolicies = accessPolicies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Open authentication policies. </summary>
        public IDictionary<string, OpenAuthenticationAccessPolicy> AccessPolicies { get; }
    }
}
