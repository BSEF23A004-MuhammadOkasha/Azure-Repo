// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderRegistrationListResult. </summary>
    internal partial class ProviderRegistrationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationListResult"/>. </summary>
        internal ProviderRegistrationListResult()
        {
            Value = new ChangeTrackingList<ProviderRegistrationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URL to get to the next set of results, if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderRegistrationListResult(IReadOnlyList<ProviderRegistrationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ProviderRegistrationData> Value { get; }
        /// <summary> The URL to get to the next set of results, if there are any. </summary>
        public string NextLink { get; }
    }
}
