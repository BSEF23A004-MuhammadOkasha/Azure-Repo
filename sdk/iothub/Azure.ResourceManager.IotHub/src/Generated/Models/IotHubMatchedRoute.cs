// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Routes that matched. </summary>
    public partial class IotHubMatchedRoute
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubMatchedRoute"/>. </summary>
        internal IotHubMatchedRoute()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubMatchedRoute"/>. </summary>
        /// <param name="properties"> Properties of routes that matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubMatchedRoute(RoutingRuleProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties of routes that matched. </summary>
        public RoutingRuleProperties Properties { get; }
    }
}
