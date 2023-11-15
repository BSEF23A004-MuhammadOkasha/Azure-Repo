// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> SKU discovery information. </summary>
    public partial class AppServicePoolSkuInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServicePoolSkuInfo"/>. </summary>
        internal AppServicePoolSkuInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServicePoolSkuInfo"/>. </summary>
        /// <param name="resourceType"> Resource type that this SKU applies to. </param>
        /// <param name="sku"> Name and tier of the SKU. </param>
        /// <param name="capacity"> Min, max, and default scale values of the SKU. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServicePoolSkuInfo(ResourceType? resourceType, AppServiceSkuDescription sku, AppServiceSkuCapacity capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource type that this SKU applies to. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Name and tier of the SKU. </summary>
        public AppServiceSkuDescription Sku { get; }
        /// <summary> Min, max, and default scale values of the SKU. </summary>
        public AppServiceSkuCapacity Capacity { get; }
    }
}
