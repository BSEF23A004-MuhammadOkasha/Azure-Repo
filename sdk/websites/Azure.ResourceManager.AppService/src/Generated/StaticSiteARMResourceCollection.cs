// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of StaticSiteARMResource and their operations over its parent. </summary>
    public partial class StaticSiteARMResourceCollection : ArmCollection, IEnumerable<StaticSiteARMResource>, IAsyncEnumerable<StaticSiteARMResource>
    {
        private readonly ClientDiagnostics _staticSiteARMResourceStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteARMResourceStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteARMResourceCollection"/> class for mocking. </summary>
        protected StaticSiteARMResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteARMResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteARMResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteARMResourceStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteARMResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteARMResource.ResourceType, out string staticSiteARMResourceStaticSitesApiVersion);
            _staticSiteARMResourceStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteARMResourceStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new static site in an existing resource group, or updates an existing static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_CreateOrUpdateStaticSite
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the static site to create or update. </param>
        /// <param name="staticSiteEnvelope"> A JSON representation of the staticsite properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="staticSiteEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteARMResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, StaticSiteARMResourceData staticSiteEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(staticSiteEnvelope, nameof(staticSiteEnvelope));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteARMResource>(new StaticSiteARMResourceOperationSource(Client), _staticSiteARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteARMResourceStaticSitesRestClient.CreateCreateOrUpdateStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a new static site in an existing resource group, or updates an existing static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_CreateOrUpdateStaticSite
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the static site to create or update. </param>
        /// <param name="staticSiteEnvelope"> A JSON representation of the staticsite properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="staticSiteEnvelope"/> is null. </exception>
        public virtual ArmOperation<StaticSiteARMResource> CreateOrUpdate(WaitUntil waitUntil, string name, StaticSiteARMResourceData staticSiteEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(staticSiteEnvelope, nameof(staticSiteEnvelope));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteARMResourceStaticSitesRestClient.CreateOrUpdateStaticSite(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteARMResource>(new StaticSiteARMResourceOperationSource(Client), _staticSiteARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteARMResourceStaticSitesRestClient.CreateCreateOrUpdateStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_GetStaticSite
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<StaticSiteARMResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_GetStaticSite
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<StaticSiteARMResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSite(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all static sites in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites
        /// Operation Id: StaticSites_GetStaticSitesByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteARMResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets all static sites in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites
        /// Operation Id: StaticSites_GetStaticSitesByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteARMResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_GetStaticSite
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_GetStaticSite
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_GetStaticSite
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<StaticSiteARMResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// Operation Id: StaticSites_GetStaticSite
        /// </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<StaticSiteARMResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSite(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteARMResource> IEnumerable<StaticSiteARMResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteARMResource> IAsyncEnumerable<StaticSiteARMResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
