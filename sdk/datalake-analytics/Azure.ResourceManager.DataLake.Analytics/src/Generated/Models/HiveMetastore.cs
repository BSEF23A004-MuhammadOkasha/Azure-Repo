// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLake.Analytics.Models
{
    /// <summary> The HiveMetastore. </summary>
    public partial class HiveMetastore : ResourceData
    {
        /// <summary> Initializes a new instance of HiveMetastore. </summary>
        internal HiveMetastore()
        {
        }

        /// <summary> Initializes a new instance of HiveMetastore. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverUri"> The serverUri for the Hive MetaStore. </param>
        /// <param name="databaseName"> The databaseName for the Hive MetaStore. </param>
        /// <param name="runtimeVersion"> The runtimeVersion for the Hive MetaStore. </param>
        /// <param name="userName"> The userName for the Hive MetaStore. </param>
        /// <param name="password"> The password for the Hive MetaStore. </param>
        /// <param name="nestedResourceProvisioningState"> The current state of the NestedResource. </param>
        internal HiveMetastore(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri serverUri, string databaseName, string runtimeVersion, string userName, string password, NestedResourceProvisioningState? nestedResourceProvisioningState) : base(id, name, resourceType, systemData)
        {
            ServerUri = serverUri;
            DatabaseName = databaseName;
            RuntimeVersion = runtimeVersion;
            UserName = userName;
            Password = password;
            NestedResourceProvisioningState = nestedResourceProvisioningState;
        }

        /// <summary> The serverUri for the Hive MetaStore. </summary>
        public Uri ServerUri { get; }
        /// <summary> The databaseName for the Hive MetaStore. </summary>
        public string DatabaseName { get; }
        /// <summary> The runtimeVersion for the Hive MetaStore. </summary>
        public string RuntimeVersion { get; }
        /// <summary> The userName for the Hive MetaStore. </summary>
        public string UserName { get; }
        /// <summary> The password for the Hive MetaStore. </summary>
        public string Password { get; }
        /// <summary> The current state of the NestedResource. </summary>
        public NestedResourceProvisioningState? NestedResourceProvisioningState { get; }
    }
}
