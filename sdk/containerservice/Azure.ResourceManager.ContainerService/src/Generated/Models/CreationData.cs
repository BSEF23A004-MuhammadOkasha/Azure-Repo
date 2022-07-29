// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Data used when creating a target resource from a source resource. </summary>
    internal partial class CreationData
    {
        /// <summary> Initializes a new instance of CreationData. </summary>
        public CreationData()
        {
        }

        /// <summary> Initializes a new instance of CreationData. </summary>
        /// <param name="sourceResourceId"> This is the ARM ID of the source object to be used to create the target object. </param>
        internal CreationData(ResourceIdentifier sourceResourceId)
        {
            SourceResourceId = sourceResourceId;
        }

        /// <summary> This is the ARM ID of the source object to be used to create the target object. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
    }
}
