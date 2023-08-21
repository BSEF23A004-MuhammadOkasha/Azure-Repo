// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A domain name and connection details used to access a dependency. </summary>
    public partial class BatchAccountEndpointDependency
    {
        /// <summary> Initializes a new instance of BatchAccountEndpointDependency. </summary>
        internal BatchAccountEndpointDependency()
        {
            EndpointDetails = new Core.ChangeTrackingList<BatchEndpointDetail>();
        }

        /// <summary> Initializes a new instance of BatchAccountEndpointDependency. </summary>
        /// <param name="domainName"> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </param>
        /// <param name="description"> Human-readable supplemental information about the dependency and when it is applicable. </param>
        /// <param name="endpointDetails"> The list of connection details for this endpoint. </param>
        internal BatchAccountEndpointDependency(string domainName, string description, IReadOnlyList<BatchEndpointDetail> endpointDetails)
        {
            DomainName = domainName;
            Description = description;
            EndpointDetails = endpointDetails;
        }

        /// <summary> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </summary>
        public string DomainName { get; }
        /// <summary> Human-readable supplemental information about the dependency and when it is applicable. </summary>
        public string Description { get; }
        /// <summary> The list of connection details for this endpoint. </summary>
        public IReadOnlyList<BatchEndpointDetail> EndpointDetails { get; }
    }
}
