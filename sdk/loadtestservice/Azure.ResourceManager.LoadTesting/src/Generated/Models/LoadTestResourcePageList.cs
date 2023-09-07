// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LoadTesting;

namespace Azure.ResourceManager.LoadTesting.Models
{
    /// <summary> List of resources page result. </summary>
    internal partial class LoadTestResourcePageList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LoadTestResourcePageList"/>. </summary>
        internal LoadTestResourcePageList()
        {
            Value = new ChangeTrackingList<LoadTestingResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="LoadTestResourcePageList"/>. </summary>
        /// <param name="value"> List of resources in current page. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadTestResourcePageList(IReadOnlyList<LoadTestingResourceData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of resources in current page. </summary>
        public IReadOnlyList<LoadTestingResourceData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
