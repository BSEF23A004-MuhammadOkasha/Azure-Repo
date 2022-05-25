// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure Data Lake Gen1 datastore configuration. </summary>
    public partial class AzureDataLakeGen1Datastore : DatastoreProperties
    {
        /// <summary> Initializes a new instance of AzureDataLakeGen1Datastore. </summary>
        /// <param name="credentials"> [Required] Account credentials. </param>
        /// <param name="storeName"> [Required] Azure Data Lake store name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> or <paramref name="storeName"/> is null. </exception>
        public AzureDataLakeGen1Datastore(DatastoreCredentials credentials, string storeName) : base(credentials)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            if (storeName == null)
            {
                throw new ArgumentNullException(nameof(storeName));
            }

            StoreName = storeName;
            DatastoreType = DatastoreType.AzureDataLakeGen1;
        }

        /// <summary> Initializes a new instance of AzureDataLakeGen1Datastore. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="credentials"> [Required] Account credentials. </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer&apos;s storage. </param>
        /// <param name="storeName"> [Required] Azure Data Lake store name. </param>
        internal AzureDataLakeGen1Datastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, DatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault, ServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity, string storeName) : base(description, properties, tags, credentials, datastoreType, isDefault)
        {
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            StoreName = storeName;
            DatastoreType = datastoreType;
        }

        /// <summary> Indicates which identity to use to authenticate service data access to customer&apos;s storage. </summary>
        public ServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
        /// <summary> [Required] Azure Data Lake store name. </summary>
        public string StoreName { get; set; }
    }
}
