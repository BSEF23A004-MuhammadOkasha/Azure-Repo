// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The properties of the source resource that this restore point collection is created from. </summary>
    public partial class RestorePointGroupSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RestorePointGroupSource"/>. </summary>
        public RestorePointGroupSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorePointGroupSource"/>. </summary>
        /// <param name="location"> Location of the source resource used to create this restore point collection. </param>
        /// <param name="id"> Resource Id of the source resource used to create this restore point collection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorePointGroupSource(AzureLocation? location, ResourceIdentifier id, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Location of the source resource used to create this restore point collection. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Resource Id of the source resource used to create this restore point collection. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
