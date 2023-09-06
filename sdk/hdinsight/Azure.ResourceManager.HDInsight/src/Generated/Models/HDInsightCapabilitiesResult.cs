// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The Get Capabilities operation response. </summary>
    public partial class HDInsightCapabilitiesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightCapabilitiesResult"/>. </summary>
        internal HDInsightCapabilitiesResult()
        {
            Versions = new ChangeTrackingDictionary<string, HDInsightVersionsCapability>();
            Regions = new ChangeTrackingDictionary<string, RegionsCapability>();
            Features = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightCapabilitiesResult"/>. </summary>
        /// <param name="versions"> The version capability. </param>
        /// <param name="regions"> The virtual machine size compatibility features. </param>
        /// <param name="features"> The capability features. </param>
        /// <param name="quota"> The quota capability. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightCapabilitiesResult(IReadOnlyDictionary<string, HDInsightVersionsCapability> versions, IReadOnlyDictionary<string, RegionsCapability> regions, IReadOnlyList<string> features, QuotaCapability quota, Dictionary<string, BinaryData> rawData)
        {
            Versions = versions;
            Regions = regions;
            Features = features;
            Quota = quota;
            _rawData = rawData;
        }

        /// <summary> The version capability. </summary>
        public IReadOnlyDictionary<string, HDInsightVersionsCapability> Versions { get; }
        /// <summary> The virtual machine size compatibility features. </summary>
        public IReadOnlyDictionary<string, RegionsCapability> Regions { get; }
        /// <summary> The capability features. </summary>
        public IReadOnlyList<string> Features { get; }
        /// <summary> The quota capability. </summary>
        public QuotaCapability Quota { get; }
    }
}
