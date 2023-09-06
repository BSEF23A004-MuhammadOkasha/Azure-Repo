// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary>
    /// A class representing the EdgeOrderAddress data model.
    /// Address Resource.
    /// </summary>
    public partial class EdgeOrderAddressData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="contactDetails"> Contact details for the address. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactDetails"/> is null. </exception>
        public EdgeOrderAddressData(AzureLocation location, EdgeOrderAddressContactDetails contactDetails) : base(location)
        {
            Argument.AssertNotNull(contactDetails, nameof(contactDetails));

            ContactDetails = contactDetails;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="shippingAddress"> Shipping details for the address. </param>
        /// <param name="contactDetails"> Contact details for the address. </param>
        /// <param name="addressValidationStatus"> Status of address validation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderAddressData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EdgeOrderShippingAddress shippingAddress, EdgeOrderAddressContactDetails contactDetails, EdgeOrderAddressValidationStatus? addressValidationStatus, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ShippingAddress = shippingAddress;
            ContactDetails = contactDetails;
            AddressValidationStatus = addressValidationStatus;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressData"/> for deserialization. </summary>
        internal EdgeOrderAddressData()
        {
        }

        /// <summary> Shipping details for the address. </summary>
        public EdgeOrderShippingAddress ShippingAddress { get; set; }
        /// <summary> Contact details for the address. </summary>
        public EdgeOrderAddressContactDetails ContactDetails { get; set; }
        /// <summary> Status of address validation. </summary>
        public EdgeOrderAddressValidationStatus? AddressValidationStatus { get; }
    }
}
