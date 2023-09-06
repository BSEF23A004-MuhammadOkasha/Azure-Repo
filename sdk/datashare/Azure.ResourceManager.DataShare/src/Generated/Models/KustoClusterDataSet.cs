// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A kusto cluster data set. </summary>
    public partial class KustoClusterDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of <see cref="KustoClusterDataSet"/>. </summary>
        /// <param name="kustoClusterResourceId"> Resource id of the kusto cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kustoClusterResourceId"/> is null. </exception>
        public KustoClusterDataSet(ResourceIdentifier kustoClusterResourceId)
        {
            Argument.AssertNotNull(kustoClusterResourceId, nameof(kustoClusterResourceId));

            KustoClusterResourceId = kustoClusterResourceId;
            Kind = DataSetKind.KustoCluster;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterDataSet"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="kustoClusterResourceId"> Resource id of the kusto cluster. </param>
        /// <param name="location"> Location of the kusto cluster. </param>
        /// <param name="provisioningState"> Provisioning state of the kusto cluster data set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoClusterDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, Guid? dataSetId, ResourceIdentifier kustoClusterResourceId, AzureLocation? location, DataShareProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, rawData)
        {
            DataSetId = dataSetId;
            KustoClusterResourceId = kustoClusterResourceId;
            Location = location;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterDataSet"/> for deserialization. </summary>
        internal KustoClusterDataSet()
        {
        }

        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Resource id of the kusto cluster. </summary>
        public ResourceIdentifier KustoClusterResourceId { get; set; }
        /// <summary> Location of the kusto cluster. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Provisioning state of the kusto cluster data set. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
    }
}
