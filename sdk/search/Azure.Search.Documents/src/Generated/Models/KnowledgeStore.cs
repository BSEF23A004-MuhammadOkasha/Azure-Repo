// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Definition of additional projections to azure blob, table, or files, of enriched data. </summary>
    public partial class KnowledgeStore
    {
        /// <summary> Initializes a new instance of KnowledgeStore. </summary>
        /// <param name="storageConnectionString"> The connection string to the storage account projections will be stored in. </param>
        /// <param name="projections"> A list of additional projections to perform during indexing. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageConnectionString"/> or <paramref name="projections"/> is null. </exception>
        public KnowledgeStore(string storageConnectionString, IEnumerable<KnowledgeStoreProjection> projections)
        {
            Argument.AssertNotNull(storageConnectionString, nameof(storageConnectionString));
            Argument.AssertNotNull(projections, nameof(projections));

            StorageConnectionString = storageConnectionString;
            Projections = projections.ToList();
        }

        /// <summary> Initializes a new instance of KnowledgeStore. </summary>
        /// <param name="storageConnectionString"> The connection string to the storage account projections will be stored in. </param>
        /// <param name="projections"> A list of additional projections to perform during indexing. </param>
        /// <param name="identity">
        /// The user-assigned managed identity used for connections to Azure Storage when writing knowledge store projections. If the connection string indicates an identity (ResourceId) and it's not specified, the system-assigned managed identity is used. On updates to the indexer, if the identity is unspecified, the value remains unchanged. If set to "none", the value of this property is cleared.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </param>
        /// <param name="parameters"> A dictionary of knowledge store-specific configuration properties. Each name is the name of a specific property. Each value must be of a primitive type. </param>
        internal KnowledgeStore(string storageConnectionString, IList<KnowledgeStoreProjection> projections, SearchIndexerDataIdentity identity, SearchIndexerKnowledgeStoreParameters parameters)
        {
            StorageConnectionString = storageConnectionString;
            Projections = projections;
            Identity = identity;
            Parameters = parameters;
        }

        /// <summary> The connection string to the storage account projections will be stored in. </summary>
        public string StorageConnectionString { get; set; }
        /// <summary> A list of additional projections to perform during indexing. </summary>
        public IList<KnowledgeStoreProjection> Projections { get; }
        /// <summary>
        /// The user-assigned managed identity used for connections to Azure Storage when writing knowledge store projections. If the connection string indicates an identity (ResourceId) and it's not specified, the system-assigned managed identity is used. On updates to the indexer, if the identity is unspecified, the value remains unchanged. If set to "none", the value of this property is cleared.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </summary>
        public SearchIndexerDataIdentity Identity { get; set; }
        /// <summary> A dictionary of knowledge store-specific configuration properties. Each name is the name of a specific property. Each value must be of a primitive type. </summary>
        public SearchIndexerKnowledgeStoreParameters Parameters { get; set; }
    }
}
