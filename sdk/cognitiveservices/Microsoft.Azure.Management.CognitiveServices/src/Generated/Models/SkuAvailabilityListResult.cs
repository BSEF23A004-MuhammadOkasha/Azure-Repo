// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Check SKU availability result list.
    /// </summary>
    public partial class SkuAvailabilityListResult
    {
        /// <summary>
        /// Initializes a new instance of the SkuAvailabilityListResult class.
        /// </summary>
        public SkuAvailabilityListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuAvailabilityListResult class.
        /// </summary>
        /// <param name="value">Check SKU availability result list.</param>
        public SkuAvailabilityListResult(IList<SkuAvailability> value = default(IList<SkuAvailability>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets check SKU availability result list.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SkuAvailability> Value { get; set; }

    }
}
