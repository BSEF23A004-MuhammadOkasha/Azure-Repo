// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Paged Quota Counter list representation.
    /// </summary>
    public partial class QuotaCounterCollection
    {
        /// <summary>
        /// Initializes a new instance of the QuotaCounterCollection class.
        /// </summary>
        public QuotaCounterCollection()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaCounterCollection class.
        /// </summary>
        /// <param name="value">Quota counter values.</param>
        /// <param name="count">Total record count number across all
        /// pages.</param>
        /// <param name="nextLink">Next page link if any.</param>
        public QuotaCounterCollection(IList<QuotaCounterContract> value = default(IList<QuotaCounterContract>), long? count = default(long?), string nextLink = default(string))
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets quota counter values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<QuotaCounterContract> Value { get; set; }

        /// <summary>
        /// Gets or sets total record count number across all pages.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets next page link if any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
