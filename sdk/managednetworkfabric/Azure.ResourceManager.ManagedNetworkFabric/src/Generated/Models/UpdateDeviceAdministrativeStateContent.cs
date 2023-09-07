// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Update the administrative state on list of resources. </summary>
    public partial class UpdateDeviceAdministrativeStateContent : UpdateAdministrativeStateOnResources
    {
        /// <summary> Initializes a new instance of <see cref="UpdateDeviceAdministrativeStateContent"/>. </summary>
        public UpdateDeviceAdministrativeStateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDeviceAdministrativeStateContent"/>. </summary>
        /// <param name="resourceIds"> Network Fabrics or Network Rack resource Id. </param>
        /// <param name="state"> Administrative state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateDeviceAdministrativeStateContent(IList<ResourceIdentifier> resourceIds, NetworkDeviceAdministrativeState? state, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceIds, serializedAdditionalRawData)
        {
            State = state;
        }

        /// <summary> Administrative state. </summary>
        public NetworkDeviceAdministrativeState? State { get; set; }
    }
}
