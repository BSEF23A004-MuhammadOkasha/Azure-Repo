// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Collection of all the containers on the Data Box Edge/Gateway device. </summary>
    internal partial class ContainerList
    {
        /// <summary> Initializes a new instance of ContainerList. </summary>
        internal ContainerList()
        {
            Value = new ChangeTrackingList<ContainerData>();
        }

        /// <summary> Initializes a new instance of ContainerList. </summary>
        /// <param name="value"> The list of containers. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal ContainerList(IReadOnlyList<ContainerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of containers. </summary>
        public IReadOnlyList<ContainerData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
