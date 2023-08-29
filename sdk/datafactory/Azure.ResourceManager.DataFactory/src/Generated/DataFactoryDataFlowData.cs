// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryDataFlow data model.
    /// Data flow resource type.
    /// </summary>
    public partial class DataFactoryDataFlowData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowData"/>. </summary>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletProperties"/>, <see cref="DataFactoryMappingDataFlowProperties"/> and <see cref="DataFactoryWranglingDataFlowProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryDataFlowData(DataFactoryDataFlowProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletProperties"/>, <see cref="DataFactoryMappingDataFlowProperties"/> and <see cref="DataFactoryWranglingDataFlowProperties"/>.
        /// </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryDataFlowData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryDataFlowProperties properties, ETag? eTag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowData"/> for deserialization. </summary>
        internal DataFactoryDataFlowData()
        {
        }

        /// <summary>
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletProperties"/>, <see cref="DataFactoryMappingDataFlowProperties"/> and <see cref="DataFactoryWranglingDataFlowProperties"/>.
        /// </summary>
        public DataFactoryDataFlowProperties Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
