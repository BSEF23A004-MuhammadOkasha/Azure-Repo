// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DataLakeAnalyticsSchemaProperties. </summary>
    internal partial class DataLakeAnalyticsSchemaProperties
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsSchemaProperties. </summary>
        public DataLakeAnalyticsSchemaProperties()
        {
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsSchemaProperties. </summary>
        /// <param name="dataLakeStoreAccountName"> DataLake Store Account Name. </param>
        internal DataLakeAnalyticsSchemaProperties(string dataLakeStoreAccountName)
        {
            DataLakeStoreAccountName = dataLakeStoreAccountName;
        }

        /// <summary> DataLake Store Account Name. </summary>
        public string DataLakeStoreAccountName { get; set; }
    }
}
