// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing the PeeringRegisteredPrefix data model.
    /// The customer's prefix that is registered by the peering service provider.
    /// </summary>
    public partial class PeeringRegisteredPrefixData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeeringRegisteredPrefixData"/>. </summary>
        public PeeringRegisteredPrefixData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeeringRegisteredPrefixData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="prefix"> The customer's prefix from which traffic originates. </param>
        /// <param name="prefixValidationState"> The prefix validation state. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key that is to be shared with the customer. </param>
        /// <param name="errorMessage"> The error message associated with the validation state, if any. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringRegisteredPrefixData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string prefix, PeeringPrefixValidationState? prefixValidationState, string peeringServicePrefixKey, string errorMessage, PeeringProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Prefix = prefix;
            PrefixValidationState = prefixValidationState;
            PeeringServicePrefixKey = peeringServicePrefixKey;
            ErrorMessage = errorMessage;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The customer's prefix from which traffic originates. </summary>
        public string Prefix { get; set; }
        /// <summary> The prefix validation state. </summary>
        public PeeringPrefixValidationState? PrefixValidationState { get; }
        /// <summary> The peering service prefix key that is to be shared with the customer. </summary>
        public string PeeringServicePrefixKey { get; }
        /// <summary> The error message associated with the validation state, if any. </summary>
        public string ErrorMessage { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public PeeringProvisioningState? ProvisioningState { get; }
    }
}
