// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Paged instance of DistributionPolicy. </summary>
    public partial class DistributionPolicyItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DistributionPolicyItem"/>. </summary>
        internal DistributionPolicyItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DistributionPolicyItem"/>. </summary>
        /// <param name="distributionPolicy"> Policy governing how jobs are distributed to workers. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DistributionPolicyItem(DistributionPolicy distributionPolicy, string etag, Dictionary<string, BinaryData> rawData)
        {
            DistributionPolicy = distributionPolicy;
            _etag = etag;
            _rawData = rawData;
        }

        /// <summary> Policy governing how jobs are distributed to workers. </summary>
        public DistributionPolicy DistributionPolicy { get; }
    }
}
