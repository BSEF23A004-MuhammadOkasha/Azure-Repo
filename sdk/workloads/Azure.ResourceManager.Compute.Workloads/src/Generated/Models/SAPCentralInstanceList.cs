// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Workloads;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> Defines the collection of SAP Central Instances. </summary>
    internal partial class SAPCentralInstanceList
    {
        /// <summary> Initializes a new instance of SAPCentralInstanceList. </summary>
        internal SAPCentralInstanceList()
        {
            Value = new ChangeTrackingList<SAPCentralServerInstanceData>();
        }

        /// <summary> Initializes a new instance of SAPCentralInstanceList. </summary>
        /// <param name="value"> Gets the list of SAP central instances. </param>
        /// <param name="nextLink"> Gets the value of next link. </param>
        internal SAPCentralInstanceList(IReadOnlyList<SAPCentralServerInstanceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of SAP central instances. </summary>
        public IReadOnlyList<SAPCentralServerInstanceData> Value { get; }
        /// <summary> Gets the value of next link. </summary>
        public string NextLink { get; }
    }
}
