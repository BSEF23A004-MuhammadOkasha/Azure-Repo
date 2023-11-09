// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application gateway BackendHealth pool. </summary>
    public partial class ApplicationGatewayBackendHealthPool
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthPool"/>. </summary>
        internal ApplicationGatewayBackendHealthPool()
        {
            BackendHttpSettingsCollection = new ChangeTrackingList<ApplicationGatewayBackendHealthHttpSettings>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthPool"/>. </summary>
        /// <param name="backendAddressPool"> Reference to an ApplicationGatewayBackendAddressPool resource. </param>
        /// <param name="backendHttpSettingsCollection"> List of ApplicationGatewayBackendHealthHttpSettings resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayBackendHealthPool(ApplicationGatewayBackendAddressPool backendAddressPool, IReadOnlyList<ApplicationGatewayBackendHealthHttpSettings> backendHttpSettingsCollection, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackendAddressPool = backendAddressPool;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Reference to an ApplicationGatewayBackendAddressPool resource. </summary>
        public ApplicationGatewayBackendAddressPool BackendAddressPool { get; }
        /// <summary> List of ApplicationGatewayBackendHealthHttpSettings resources. </summary>
        public IReadOnlyList<ApplicationGatewayBackendHealthHttpSettings> BackendHttpSettingsCollection { get; }
    }
}
