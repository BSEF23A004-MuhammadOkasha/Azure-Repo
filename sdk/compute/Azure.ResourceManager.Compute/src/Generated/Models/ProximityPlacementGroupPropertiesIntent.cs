// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the user intent of the proximity placement group. </summary>
    internal partial class ProximityPlacementGroupPropertiesIntent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupPropertiesIntent"/>. </summary>
        public ProximityPlacementGroupPropertiesIntent()
        {
            VmSizes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupPropertiesIntent"/>. </summary>
        /// <param name="vmSizes"> Specifies possible sizes of virtual machines that can be created in the proximity placement group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProximityPlacementGroupPropertiesIntent(IList<string> vmSizes, Dictionary<string, BinaryData> rawData)
        {
            VmSizes = vmSizes;
            _rawData = rawData;
        }

        /// <summary> Specifies possible sizes of virtual machines that can be created in the proximity placement group. </summary>
        public IList<string> VmSizes { get; }
    }
}
