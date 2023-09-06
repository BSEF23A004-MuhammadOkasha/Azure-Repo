// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Input values. </summary>
    public partial class HealthcareApisNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareApisNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the service instance to check. </param>
        /// <param name="resourceType"> The fully qualified resource type which includes provider namespace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HealthcareApisNameAvailabilityContent(string name, ResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the service instance to check. </param>
        /// <param name="resourceType"> The fully qualified resource type which includes provider namespace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareApisNameAvailabilityContent(string name, ResourceType resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisNameAvailabilityContent"/> for deserialization. </summary>
        internal HealthcareApisNameAvailabilityContent()
        {
        }

        /// <summary> The name of the service instance to check. </summary>
        public string Name { get; }
        /// <summary> The fully qualified resource type which includes provider namespace. </summary>
        public ResourceType ResourceType { get; }
    }
}
