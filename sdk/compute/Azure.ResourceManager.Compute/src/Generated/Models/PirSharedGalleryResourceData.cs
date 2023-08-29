// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Base information about the shared gallery resource in pir. </summary>
    public partial class PirSharedGalleryResourceData : PirResourceData
    {
        /// <summary> Initializes a new instance of <see cref="PirSharedGalleryResourceData"/>. </summary>
        internal PirSharedGalleryResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PirSharedGalleryResourceData"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PirSharedGalleryResourceData(string name, AzureLocation? location, string uniqueId, Dictionary<string, BinaryData> rawData) : base(name, location, rawData)
        {
            UniqueId = uniqueId;
        }

        /// <summary> The unique id of this shared gallery. </summary>
        public string UniqueId { get; }
    }
}
