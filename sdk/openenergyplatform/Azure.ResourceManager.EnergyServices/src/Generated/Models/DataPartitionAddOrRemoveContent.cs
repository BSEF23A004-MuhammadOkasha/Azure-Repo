// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> Defines the partition add/ delete action properties. </summary>
    public partial class DataPartitionAddOrRemoveContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataPartitionAddOrRemoveContent"/>. </summary>
        public DataPartitionAddOrRemoveContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataPartitionAddOrRemoveContent"/>. </summary>
        /// <param name="name"> The list of Energy services resource's Data Partition Names. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataPartitionAddOrRemoveContent(DataPartitionName name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }
    }
}
