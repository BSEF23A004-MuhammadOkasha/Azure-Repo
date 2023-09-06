// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    /// <summary> Emission policy properties. </summary>
    public partial class EmissionPoliciesPropertiesFormat
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EmissionPoliciesPropertiesFormat"/>. </summary>
        public EmissionPoliciesPropertiesFormat()
        {
            EmissionDestinations = new ChangeTrackingList<EmissionPolicyDestination>();
        }

        /// <summary> Initializes a new instance of <see cref="EmissionPoliciesPropertiesFormat"/>. </summary>
        /// <param name="emissionType"> Emission format type. </param>
        /// <param name="emissionDestinations"> Emission policy destinations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EmissionPoliciesPropertiesFormat(EmissionType? emissionType, IList<EmissionPolicyDestination> emissionDestinations, Dictionary<string, BinaryData> rawData)
        {
            EmissionType = emissionType;
            EmissionDestinations = emissionDestinations;
            _rawData = rawData;
        }

        /// <summary> Emission format type. </summary>
        public EmissionType? EmissionType { get; set; }
        /// <summary> Emission policy destinations. </summary>
        public IList<EmissionPolicyDestination> EmissionDestinations { get; }
    }
}
