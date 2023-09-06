// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary> Check Name Availability Request. </summary>
    public partial class MixedRealityNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MixedRealityNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource Name To Verify. </param>
        /// <param name="resourceType"> Fully qualified resource type which includes provider namespace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceType"/> is null. </exception>
        public MixedRealityNameAvailabilityContent(string name, string resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(resourceType, nameof(resourceType));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="MixedRealityNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource Name To Verify. </param>
        /// <param name="resourceType"> Fully qualified resource type which includes provider namespace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MixedRealityNameAvailabilityContent(string name, string resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MixedRealityNameAvailabilityContent"/> for deserialization. </summary>
        internal MixedRealityNameAvailabilityContent()
        {
        }

        /// <summary> Resource Name To Verify. </summary>
        public string Name { get; }
        /// <summary> Fully qualified resource type which includes provider namespace. </summary>
        public string ResourceType { get; }
    }
}
