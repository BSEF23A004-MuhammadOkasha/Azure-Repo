// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PolicyInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="PolicyMetadataResource" /> and their operations.
    /// Each <see cref="PolicyMetadataResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="PolicyMetadataCollection" /> instance call the GetPolicyMetadata method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class PolicyMetadataCollection : ArmCollection, IEnumerable<SlimPolicyMetadata>, IAsyncEnumerable<SlimPolicyMetadata>
    {
        private readonly ClientDiagnostics _policyMetadataPolicyMetadataClientDiagnostics;
        private readonly PolicyMetadataRestOperations _policyMetadataPolicyMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyMetadataCollection"/> class for mocking. </summary>
        protected PolicyMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyMetadataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PolicyMetadataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyMetadataPolicyMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", PolicyMetadataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PolicyMetadataResource.ResourceType, out string policyMetadataPolicyMetadataApiVersion);
            _policyMetadataPolicyMetadataRestClient = new PolicyMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyMetadataPolicyMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get policy metadata resource.
        /// Request Path: /providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}
        /// Operation Id: PolicyMetadata_GetResource
        /// </summary>
        /// <param name="resourceName"> The name of the policy metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<PolicyMetadataResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceName, nameof(resourceName));

            using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyMetadataPolicyMetadataRestClient.GetResourceAsync(resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get policy metadata resource.
        /// Request Path: /providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}
        /// Operation Id: PolicyMetadata_GetResource
        /// </summary>
        /// <param name="resourceName"> The name of the policy metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<PolicyMetadataResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceName, nameof(resourceName));

            using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _policyMetadataPolicyMetadataRestClient.GetResource(resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of the policy metadata resources.
        /// Request Path: /providers/Microsoft.PolicyInsights/policyMetadata
        /// Operation Id: PolicyMetadata_List
        /// </summary>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SlimPolicyMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SlimPolicyMetadata> GetAllAsync(QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SlimPolicyMetadata>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyMetadataPolicyMetadataRestClient.ListAsync(queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SlimPolicyMetadata>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyMetadataPolicyMetadataRestClient.ListNextPageAsync(nextLink, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get a list of the policy metadata resources.
        /// Request Path: /providers/Microsoft.PolicyInsights/policyMetadata
        /// Operation Id: PolicyMetadata_List
        /// </summary>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SlimPolicyMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SlimPolicyMetadata> GetAll(QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            Page<SlimPolicyMetadata> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyMetadataPolicyMetadataRestClient.List(queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SlimPolicyMetadata> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyMetadataPolicyMetadataRestClient.ListNextPage(nextLink, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}
        /// Operation Id: PolicyMetadata_GetResource
        /// </summary>
        /// <param name="resourceName"> The name of the policy metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceName, nameof(resourceName));

            using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _policyMetadataPolicyMetadataRestClient.GetResourceAsync(resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}
        /// Operation Id: PolicyMetadata_GetResource
        /// </summary>
        /// <param name="resourceName"> The name of the policy metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceName, nameof(resourceName));

            using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = _policyMetadataPolicyMetadataRestClient.GetResource(resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SlimPolicyMetadata> IEnumerable<SlimPolicyMetadata>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SlimPolicyMetadata> IAsyncEnumerable<SlimPolicyMetadata>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
