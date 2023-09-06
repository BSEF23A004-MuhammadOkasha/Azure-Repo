// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the OperationalInsightsLinkedStorageAccounts data model.
    /// Linked storage accounts top level resource container.
    /// </summary>
    public partial class OperationalInsightsLinkedStorageAccountsData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsLinkedStorageAccountsData"/>. </summary>
        public OperationalInsightsLinkedStorageAccountsData()
        {
            StorageAccountIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsLinkedStorageAccountsData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dataSourceType"> Linked storage accounts type. </param>
        /// <param name="storageAccountIds"> Linked storage accounts resources ids. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsLinkedStorageAccountsData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, OperationalInsightsDataSourceType? dataSourceType, IList<ResourceIdentifier> storageAccountIds, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            DataSourceType = dataSourceType;
            StorageAccountIds = storageAccountIds;
            _rawData = rawData;
        }

        /// <summary> Linked storage accounts type. </summary>
        public OperationalInsightsDataSourceType? DataSourceType { get; }
        /// <summary> Linked storage accounts resources ids. </summary>
        public IList<ResourceIdentifier> StorageAccountIds { get; }
    }
}
