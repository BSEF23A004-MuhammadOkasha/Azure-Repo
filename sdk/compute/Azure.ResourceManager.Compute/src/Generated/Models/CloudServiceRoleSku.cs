// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the cloud service role sku. </summary>
    public partial class CloudServiceRoleSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleSku"/>. </summary>
        public CloudServiceRoleSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleSku"/>. </summary>
        /// <param name="name"> The sku name. NOTE: If the new SKU is not supported on the hardware the cloud service is currently on, you need to delete and recreate the cloud service or move back to the old sku. </param>
        /// <param name="tier"> Specifies the tier of the cloud service. Possible Values are &lt;br /&gt;&lt;br /&gt; **Standard** &lt;br /&gt;&lt;br /&gt; **Basic**. </param>
        /// <param name="capacity"> Specifies the number of role instances in the cloud service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceRoleSku(string name, string tier, long? capacity, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The sku name. NOTE: If the new SKU is not supported on the hardware the cloud service is currently on, you need to delete and recreate the cloud service or move back to the old sku. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the tier of the cloud service. Possible Values are &lt;br /&gt;&lt;br /&gt; **Standard** &lt;br /&gt;&lt;br /&gt; **Basic**. </summary>
        public string Tier { get; set; }
        /// <summary> Specifies the number of role instances in the cloud service. </summary>
        public long? Capacity { get; set; }
    }
}
