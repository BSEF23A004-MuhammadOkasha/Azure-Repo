// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The settings that will be leveraged for Oracle source partitioning. </summary>
    public partial class OraclePartitionSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OraclePartitionSettings"/>. </summary>
        public OraclePartitionSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OraclePartitionSettings"/>. </summary>
        /// <param name="partitionNames"> Names of the physical partitions of Oracle table. </param>
        /// <param name="partitionColumnName"> The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionUpperBound"> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionLowerBound"> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OraclePartitionSettings(object partitionNames, object partitionColumnName, object partitionUpperBound, object partitionLowerBound, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PartitionNames = partitionNames;
            PartitionColumnName = partitionColumnName;
            PartitionUpperBound = partitionUpperBound;
            PartitionLowerBound = partitionLowerBound;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Names of the physical partitions of Oracle table. </summary>
        public object PartitionNames { get; set; }
        /// <summary> The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public object PartitionColumnName { get; set; }
        /// <summary> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public object PartitionUpperBound { get; set; }
        /// <summary> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public object PartitionLowerBound { get; set; }
    }
}
