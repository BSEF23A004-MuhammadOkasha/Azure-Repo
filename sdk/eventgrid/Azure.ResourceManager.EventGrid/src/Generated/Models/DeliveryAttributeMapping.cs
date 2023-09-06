// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// Delivery attribute mapping details.
    /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownDeliveryAttributeMapping))]
    public abstract partial class DeliveryAttributeMapping
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeliveryAttributeMapping"/>. </summary>
        protected DeliveryAttributeMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryAttributeMapping"/>. </summary>
        /// <param name="name"> Name of the delivery attribute or header. </param>
        /// <param name="mappingType"> Type of the delivery attribute or header name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryAttributeMapping(string name, DeliveryAttributeMappingType mappingType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            MappingType = mappingType;
            _rawData = rawData;
        }

        /// <summary> Name of the delivery attribute or header. </summary>
        public string Name { get; set; }
        /// <summary> Type of the delivery attribute or header name. </summary>
        internal DeliveryAttributeMappingType MappingType { get; set; }
    }
}
