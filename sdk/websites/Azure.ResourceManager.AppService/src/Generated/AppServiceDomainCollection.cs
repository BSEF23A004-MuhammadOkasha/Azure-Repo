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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServiceDomainResource" /> and their operations.
    /// Each <see cref="AppServiceDomainResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AppServiceDomainCollection" /> instance call the GetAppServiceDomains method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AppServiceDomainCollection : ArmCollection, IEnumerable<AppServiceDomainResource>, IAsyncEnumerable<AppServiceDomainResource>
    {
        private readonly ClientDiagnostics _appServiceDomainDomainsClientDiagnostics;
        private readonly DomainsRestOperations _appServiceDomainDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceDomainCollection"/> class for mocking. </summary>
        protected AppServiceDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceDomainDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServiceDomainResource.ResourceType, out string appServiceDomainDomainsApiVersion);
            _appServiceDomainDomainsRestClient = new DomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServiceDomainDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates or updates a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="data"> Domain registration information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, AppServiceDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceDomainResource>(new AppServiceDomainOperationSource(Client), _appServiceDomainDomainsClientDiagnostics, Pipeline, _appServiceDomainDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates or updates a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="data"> Domain registration information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServiceDomainResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, AppServiceDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, domainName, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceDomainResource>(new AppServiceDomainOperationSource(Client), _appServiceDomainDomainsClientDiagnostics, Pipeline, _appServiceDomainDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<AppServiceDomainResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppServiceDomainResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all domains in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceDomainDomainsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceDomainDomainsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppServiceDomainResource(Client, AppServiceDomainData.DeserializeAppServiceDomainData(e)), _appServiceDomainDomainsClientDiagnostics, Pipeline, "AppServiceDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get all domains in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceDomainDomainsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceDomainDomainsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppServiceDomainResource(Client, AppServiceDomainData.DeserializeAppServiceDomainData(e)), _appServiceDomainDomainsClientDiagnostics, Pipeline, "AppServiceDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppServiceDomainResource>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppServiceDomainResource>(response.GetRawResponse());
                return Response.FromValue(new AppServiceDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual NullableResponse<AppServiceDomainResource> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppServiceDomainResource>(response.GetRawResponse());
                return Response.FromValue(new AppServiceDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceDomainResource> IEnumerable<AppServiceDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceDomainResource> IAsyncEnumerable<AppServiceDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
