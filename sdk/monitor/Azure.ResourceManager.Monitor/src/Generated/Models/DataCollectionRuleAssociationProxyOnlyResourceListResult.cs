// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A pageable list of resources. </summary>
    internal partial class DataCollectionRuleAssociationProxyOnlyResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleAssociationProxyOnlyResourceListResult"/>. </summary>
        /// <param name="value"> A list of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataCollectionRuleAssociationProxyOnlyResourceListResult(IEnumerable<DataCollectionRuleAssociationData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleAssociationProxyOnlyResourceListResult"/>. </summary>
        /// <param name="value"> A list of resources. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionRuleAssociationProxyOnlyResourceListResult(IReadOnlyList<DataCollectionRuleAssociationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionRuleAssociationProxyOnlyResourceListResult"/> for deserialization. </summary>
        internal DataCollectionRuleAssociationProxyOnlyResourceListResult()
        {
        }

        /// <summary> A list of resources. </summary>
        public IReadOnlyList<DataCollectionRuleAssociationData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
