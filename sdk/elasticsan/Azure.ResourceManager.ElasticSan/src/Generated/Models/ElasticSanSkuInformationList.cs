// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> List of SKU Information objects. </summary>
    internal partial class ElasticSanSkuInformationList
    {
        /// <summary> Initializes a new instance of ElasticSanSkuInformationList. </summary>
        internal ElasticSanSkuInformationList()
        {
            Value = new ChangeTrackingList<ElasticSanSkuInformation>();
        }

        /// <summary> Initializes a new instance of ElasticSanSkuInformationList. </summary>
        /// <param name="value"> List of ResourceType Sku. </param>
        internal ElasticSanSkuInformationList(IReadOnlyList<ElasticSanSkuInformation> value)
        {
            Value = value;
        }

        /// <summary> List of ResourceType Sku. </summary>
        public IReadOnlyList<ElasticSanSkuInformation> Value { get; }
    }
}
