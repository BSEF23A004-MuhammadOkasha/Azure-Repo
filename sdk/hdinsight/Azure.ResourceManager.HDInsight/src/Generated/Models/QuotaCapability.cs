// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The regional quota capability. </summary>
    public partial class QuotaCapability
    {
        /// <summary> Initializes a new instance of QuotaCapability. </summary>
        internal QuotaCapability()
        {
            RegionalQuotas = new ChangeTrackingList<RegionalQuotaCapability>();
        }

        /// <summary> Initializes a new instance of QuotaCapability. </summary>
        /// <param name="coresUsed"> The number of cores used in the subscription. </param>
        /// <param name="maxCoresAllowed"> The number of cores that the subscription allowed. </param>
        /// <param name="regionalQuotas"> The list of region quota capabilities. </param>
        internal QuotaCapability(long? coresUsed, long? maxCoresAllowed, IReadOnlyList<RegionalQuotaCapability> regionalQuotas)
        {
            CoresUsed = coresUsed;
            MaxCoresAllowed = maxCoresAllowed;
            RegionalQuotas = regionalQuotas;
        }

        /// <summary> The number of cores used in the subscription. </summary>
        public long? CoresUsed { get; }
        /// <summary> The number of cores that the subscription allowed. </summary>
        public long? MaxCoresAllowed { get; }
        /// <summary> The list of region quota capabilities. </summary>
        public IReadOnlyList<RegionalQuotaCapability> RegionalQuotas { get; }
    }
}
