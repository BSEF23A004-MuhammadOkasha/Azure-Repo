// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of SKU information. </summary>
    public partial class AppServiceSkuResult
    {
        /// <summary> Initializes a new instance of AppServiceSkuResult. </summary>
        internal AppServiceSkuResult()
        {
            Skus = new Core.ChangeTrackingList<GlobalCsmSkuDescription>();
        }

        /// <summary> Initializes a new instance of AppServiceSkuResult. </summary>
        /// <param name="resourceType"> Resource type that this SKU applies to. </param>
        /// <param name="skus"> List of SKUs the subscription is able to use. </param>
        internal AppServiceSkuResult(ResourceType? resourceType, IReadOnlyList<GlobalCsmSkuDescription> skus)
        {
            ResourceType = resourceType;
            Skus = skus;
        }

        /// <summary> Resource type that this SKU applies to. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> List of SKUs the subscription is able to use. </summary>
        public IReadOnlyList<GlobalCsmSkuDescription> Skus { get; }
    }
}
