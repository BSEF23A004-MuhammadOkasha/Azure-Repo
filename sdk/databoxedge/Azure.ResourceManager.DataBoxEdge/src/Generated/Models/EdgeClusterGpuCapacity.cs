// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Cluster GPU Data. </summary>
    public partial class EdgeClusterGpuCapacity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeClusterGpuCapacity"/>. </summary>
        public EdgeClusterGpuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeClusterGpuCapacity"/>. </summary>
        /// <param name="gpuType"> The cluster GPU Type. </param>
        /// <param name="gpuUsedUnitsCount"> The used GPU units count in the cluster. </param>
        /// <param name="gpuFreeUnitsCount"> The free GPU units count in the cluster. </param>
        /// <param name="gpuReservedForFailoverUnitsCount"> The GPU units count reserved for failover in the cluster. </param>
        /// <param name="gpuTotalUnitsCount"> The total GPU units count in the cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeClusterGpuCapacity(string gpuType, int? gpuUsedUnitsCount, int? gpuFreeUnitsCount, int? gpuReservedForFailoverUnitsCount, int? gpuTotalUnitsCount, Dictionary<string, BinaryData> rawData)
        {
            GpuType = gpuType;
            GpuUsedUnitsCount = gpuUsedUnitsCount;
            GpuFreeUnitsCount = gpuFreeUnitsCount;
            GpuReservedForFailoverUnitsCount = gpuReservedForFailoverUnitsCount;
            GpuTotalUnitsCount = gpuTotalUnitsCount;
            _rawData = rawData;
        }

        /// <summary> The cluster GPU Type. </summary>
        public string GpuType { get; set; }
        /// <summary> The used GPU units count in the cluster. </summary>
        public int? GpuUsedUnitsCount { get; set; }
        /// <summary> The free GPU units count in the cluster. </summary>
        public int? GpuFreeUnitsCount { get; set; }
        /// <summary> The GPU units count reserved for failover in the cluster. </summary>
        public int? GpuReservedForFailoverUnitsCount { get; set; }
        /// <summary> The total GPU units count in the cluster. </summary>
        public int? GpuTotalUnitsCount { get; set; }
    }
}
