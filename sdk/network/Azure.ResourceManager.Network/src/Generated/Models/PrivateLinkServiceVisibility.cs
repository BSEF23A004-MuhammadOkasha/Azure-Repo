// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the CheckPrivateLinkServiceVisibility API service call. </summary>
    public partial class PrivateLinkServiceVisibility
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceVisibility"/>. </summary>
        internal PrivateLinkServiceVisibility()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceVisibility"/>. </summary>
        /// <param name="visible"> Private Link Service Visibility (True/False). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkServiceVisibility(bool? visible, Dictionary<string, BinaryData> rawData)
        {
            Visible = visible;
            _rawData = rawData;
        }

        /// <summary> Private Link Service Visibility (True/False). </summary>
        public bool? Visible { get; }
    }
}
