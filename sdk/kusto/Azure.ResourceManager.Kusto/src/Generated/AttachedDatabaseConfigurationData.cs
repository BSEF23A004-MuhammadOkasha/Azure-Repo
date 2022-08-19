// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    /// <summary> A class representing the AttachedDatabaseConfiguration data model. </summary>
    public partial class AttachedDatabaseConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of AttachedDatabaseConfigurationData. </summary>
        public AttachedDatabaseConfigurationData()
        {
            AttachedDatabaseNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AttachedDatabaseConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="databaseName"> The name of the database which you would like to attach, use * if you want to follow all current and future databases. </param>
        /// <param name="clusterResourceId"> The resource id of the cluster where the databases you would like to attach reside. </param>
        /// <param name="attachedDatabaseNames"> The list of databases from the clusterResourceId which are currently attached to the cluster. </param>
        /// <param name="defaultPrincipalsModificationKind"> The default principals modification kind. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing specifications. </param>
        internal AttachedDatabaseConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ProvisioningState? provisioningState, string databaseName, string clusterResourceId, IReadOnlyList<string> attachedDatabaseNames, DefaultPrincipalsModificationKind? defaultPrincipalsModificationKind, TableLevelSharingProperties tableLevelSharingProperties) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            DatabaseName = databaseName;
            ClusterResourceId = clusterResourceId;
            AttachedDatabaseNames = attachedDatabaseNames;
            DefaultPrincipalsModificationKind = defaultPrincipalsModificationKind;
            TableLevelSharingProperties = tableLevelSharingProperties;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The name of the database which you would like to attach, use * if you want to follow all current and future databases. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The resource id of the cluster where the databases you would like to attach reside. </summary>
        public string ClusterResourceId { get; set; }
        /// <summary> The list of databases from the clusterResourceId which are currently attached to the cluster. </summary>
        public IReadOnlyList<string> AttachedDatabaseNames { get; }
        /// <summary> The default principals modification kind. </summary>
        public DefaultPrincipalsModificationKind? DefaultPrincipalsModificationKind { get; set; }
        /// <summary> Table level sharing specifications. </summary>
        public TableLevelSharingProperties TableLevelSharingProperties { get; set; }
    }
}
